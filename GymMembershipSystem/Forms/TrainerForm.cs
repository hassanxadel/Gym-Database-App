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

namespace GymMembershipSystem.Forms
{
    public partial class TrainerForm : Form
    {
        public TrainerForm()
        {
            InitializeComponent();
        }

        // LOAD DATA
        private void btnLoadTrainers_Click(object sender, EventArgs e)
        {
            DatabaseHelper db = new DatabaseHelper();
            dgvTrainers.DataSource = db.ExecuteSelect("SELECT * FROM TRAINER;");
        }

        private void ClearInputs()
        {
            txtFName.Clear();
            txtLName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            cmbLevel.SelectedIndex = -1; 
        }

        private void btnDeleteTrainer_Click_1(object sender, EventArgs e)
        {
            if (dgvTrainers.SelectedRows.Count > 0)
            {
                string selectedId = dgvTrainers.SelectedRows[0].Cells["TrainerID"].Value.ToString();
                DialogResult result = MessageBox.Show("Delete this trainer?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    string query = $"DELETE FROM TRAINER WHERE TrainerID = {selectedId};";
                    DatabaseHelper db = new DatabaseHelper();
                    if (db.ExecuteAction(query))
                    {
                        MessageBox.Show("Trainer deleted!");
                        dgvTrainers.DataSource = db.ExecuteSelect("SELECT * FROM TRAINER;");
                        ClearInputs();
                    }
                }
            }
        }

        private void dgvTrainers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTrainers.Rows[e.RowIndex];
                txtFName.Text = row.Cells["FName"].Value.ToString();
                txtLName.Text = row.Cells["LName"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtPhone.Text = row.Cells["Phone"].Value.ToString();
                cmbLevel.Text = row.Cells["Level"].Value.ToString();
            }
        }

        private void btnAddTrainer_Click_1(object sender, EventArgs e)
        {
            string fName = txtFName.Text;
            string lName = txtLName.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;
            string level = cmbLevel.Text; // Getting the text from the dropdown

            string query = $"INSERT INTO TRAINER (FName, LName, Email, Phone, Level) " +
                           $"VALUES ('{fName}', '{lName}', '{email}', '{phone}', '{level}');";

            DatabaseHelper db = new DatabaseHelper();
            if (db.ExecuteAction(query))
            {
                MessageBox.Show("Trainer added successfully!");
                dgvTrainers.DataSource = db.ExecuteSelect("SELECT * FROM TRAINER;");
                ClearInputs();
            }
        }

        private void btnUpdateTrainer_Click_1(object sender, EventArgs e)
        {

            if (dgvTrainers.SelectedRows.Count > 0)
            {
                string selectedId = dgvTrainers.SelectedRows[0].Cells["TrainerID"].Value.ToString();

                string fName = txtFName.Text;
                string lName = txtLName.Text;
                string email = txtEmail.Text;
                string phone = txtPhone.Text;
                string level = cmbLevel.Text;

                string query = $"UPDATE TRAINER SET " +
                               $"FName = '{fName}', LName = '{lName}', Email = '{email}', " +
                               $"Phone = '{phone}', Level = '{level}' " +
                               $"WHERE TrainerID = {selectedId};";

                DatabaseHelper db = new DatabaseHelper();
                if (db.ExecuteAction(query))
                {
                    MessageBox.Show("Trainer updated successfully!");
                    dgvTrainers.DataSource = db.ExecuteSelect("SELECT * FROM TRAINER;");
                    ClearInputs();
                }
            }
        }

        private void dgvTrainers_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTrainers.Rows[e.RowIndex];
                txtFName.Text = row.Cells["FName"].Value.ToString();
                txtLName.Text = row.Cells["LName"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtPhone.Text = row.Cells["Phone"].Value.ToString();
                cmbLevel.Text = row.Cells["Level"].Value.ToString();
            }

        }
    }
}