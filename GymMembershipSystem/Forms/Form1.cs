using GymMembershipSystem.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GymMembershipSystem.DataAccess;

namespace GymMembershipSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoadMembers_Click(object sender, EventArgs e)
        {
            // 1. Create an instance of your helper
            DatabaseHelper db = new DatabaseHelper();

            // 2. Write your SQL query
            string query = "SELECT * FROM MEMBER;";

            // 3. Execute the query and put the result in the grid
            dgvData.DataSource = db.ExecuteSelect(query);

        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {

            // 1. Grab the data the user typed into the form
            string fName = txtFName.Text;
            string lName = txtLName.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;

            // MySQL strictly requires dates to be in YYYY-MM-DD format
            string dob = dtpDOB.Value.ToString("yyyy-MM-dd");
            string joinDate = dtpJoinDate.Value.ToString("yyyy-MM-dd");

            // 2. Build the exact INSERT SQL query
            string query = $"INSERT INTO MEMBER (FName, LName, Email, Phone, DateOfBirth, JoinDate) " +
                           $"VALUES ('{fName}', '{lName}', '{email}', '{phone}', '{dob}', '{joinDate}');";

            // 3. Connect to the database and execute the query
            DatabaseHelper db = new DatabaseHelper();
            bool success = db.ExecuteAction(query);

            // 4. If it worked, tell the user and refresh the grid!
            if (success)
            {
                MessageBox.Show("Member successfully added to the database!");

                // This instantly refreshes the grid so you can see the new person
                dgvData.DataSource = db.ExecuteSelect("SELECT * FROM MEMBER;");

                // Optional: Clear the text boxes for the next entry
                txtFName.Clear();
                txtLName.Clear();
                txtEmail.Clear();
                txtPhone.Clear();
            }
        }

        private void btnDeleteMember_Click(object sender, EventArgs e)
        {
            // 1. Check if the user actually has a row selected in the grid
            if (dgvData.SelectedRows.Count > 0)
            {
                // 2. Grab the MemberID from the very first column of the selected row
                // We use the ID because it is the Primary Key (the only safe way to delete)
                string selectedId = dgvData.SelectedRows[0].Cells["MemberID"].Value.ToString();

                // 3. Ask for confirmation (Always a good idea before deleting data!)
                DialogResult result = MessageBox.Show("Are you sure you want to permanently delete this member?",
                                                      "Confirm Deletion",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // 4. Write the SQL DELETE query
                    string query = $"DELETE FROM MEMBER WHERE MemberID = {selectedId};";

                    // 5. Execute it using your helper class
                    DatabaseHelper db = new DatabaseHelper();
                    bool success = db.ExecuteAction(query);

                    if (success)
                    {
                        MessageBox.Show("Member deleted successfully!");
                        // Refresh the grid so the deleted person disappears
                        dgvData.DataSource = db.ExecuteSelect("SELECT * FROM MEMBER;");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please click on a member in the grid first to select them for deletion.", "Selection Required");
            }
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Make sure the user clicked an actual row, not the column headers at the top
            if (e.RowIndex >= 0)
            {
                // Grab the specific row that was clicked
                DataGridViewRow row = dgvData.Rows[e.RowIndex];

                // Push the text data from the grid into the text boxes
                txtFName.Text = row.Cells["FName"].Value.ToString();
                txtLName.Text = row.Cells["LName"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtPhone.Text = row.Cells["Phone"].Value.ToString();

                // Push the dates into the DateTimePickers (we use TryParse to prevent errors if the date is empty)
                if (DateTime.TryParse(row.Cells["DateOfBirth"].Value.ToString(), out DateTime dob))
                {
                    dtpDOB.Value = dob;
                }
                if (DateTime.TryParse(row.Cells["JoinDate"].Value.ToString(), out DateTime joinDate))
                {
                    dtpJoinDate.Value = joinDate;
                }
            }
        }

        private void btnUpdateMember_Click(object sender, EventArgs e)
        {
            // 1. Verify a row is actually selected in the grid
            if (dgvData.SelectedRows.Count > 0)
            {
                // 2. Get the MemberID of the selected person so the database knows WHO to update
                string selectedId = dgvData.SelectedRows[0].Cells["MemberID"].Value.ToString();

                // 3. Grab the fresh, newly edited data from the text boxes
                string fName = txtFName.Text;
                string lName = txtLName.Text;
                string email = txtEmail.Text;
                string phone = txtPhone.Text;
                string dob = dtpDOB.Value.ToString("yyyy-MM-dd");
                string joinDate = dtpJoinDate.Value.ToString("yyyy-MM-dd");

                // 4. Build the SQL UPDATE query
                string query = $"UPDATE MEMBER SET " +
                               $"FName = '{fName}', " +
                               $"LName = '{lName}', " +
                               $"Email = '{email}', " +
                               $"Phone = '{phone}', " +
                               $"DateOfBirth = '{dob}', " +
                               $"JoinDate = '{joinDate}' " +
                               $"WHERE MemberID = {selectedId};";

                // 5. Execute the update
                DatabaseHelper db = new DatabaseHelper();
                bool success = db.ExecuteAction(query);

                // 6. Refresh the grid to show the changes
                if (success)
                {
                    MessageBox.Show("Member updated successfully!");
                    dgvData.DataSource = db.ExecuteSelect("SELECT * FROM MEMBER;");

                    // Optional: Clear the boxes after updating
                    txtFName.Clear();
                    txtLName.Clear();
                    txtEmail.Clear();
                    txtPhone.Clear();
                }
            }
            else
            {
                MessageBox.Show("Please select a member from the grid first, edit their details in the boxes, then click Update.", "Selection Required");
            }
        }
    }
    }
    
