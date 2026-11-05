using GymMembershipSystem.DataAccess;
using MySql.Data.MySqlClient;
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
    public partial class EnrollmentForm: Form
    {
        public EnrollmentForm()
        {
            InitializeComponent();
            UiTheme.Apply(this);
            LoadReferenceLists();
        }

        private void btnAddEnrollment_Click(object sender, EventArgs e)
        {
            string memberId = txtMemberID.Text;
            string classId = txtClassID.Text;

            string enrollmentDate = dtpEnrollmentDate.Value.ToString("yyyy-MM-dd HH:mm:ss");

            string query = "INSERT INTO ENROLLMENT (MemberID, ClassID, EnrollmentDate) " +
                           "VALUES (@memberId, @classId, @enrollmentDate);";

            DatabaseHelper db = new DatabaseHelper();
            if (db.ExecuteAction(query,
                new MySqlParameter("@memberId", memberId),
                new MySqlParameter("@classId", classId),
                new MySqlParameter("@enrollmentDate", enrollmentDate)))
            {
                MessageBox.Show("Enrollment logged successfully!");
                dgvEnrollments.DataSource = db.ExecuteSelect("SELECT * FROM ENROLLMENT;");
                ClearInputs();
            }
        }

        private void btnLoadEnrollments_Click(object sender, EventArgs e)
        {
            DatabaseHelper db = new DatabaseHelper();
            dgvEnrollments.DataSource = db.ExecuteSelect("SELECT * FROM ENROLLMENT;");
        }

        private void dgvEnrollments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvEnrollments.Rows[e.RowIndex];
                txtMemberID.Text = row.Cells["MemberID"].Value.ToString();
                txtClassID.Text = row.Cells["ClassID"].Value.ToString();

                // Safely parse the exact date and time
                if (DateTime.TryParse(row.Cells["EnrollmentDate"].Value.ToString(), out DateTime eDate))
                {
                    dtpEnrollmentDate.Value = eDate;
                }
            }
        }

        private void btnUpdateEnrollment_Click(object sender, EventArgs e)
        {
            if (dgvEnrollments.SelectedRows.Count > 0)
            {
                string selectedId = dgvEnrollments.SelectedRows[0].Cells["EnrollmentID"].Value.ToString();

                string memberId = txtMemberID.Text;
                string classId = txtClassID.Text;
                string enrollmentDate = dtpEnrollmentDate.Value.ToString("yyyy-MM-dd HH:mm:ss");

                string query = "UPDATE ENROLLMENT SET " +
                               "MemberID = @memberId, ClassID = @classId, " +
                               "EnrollmentDate = @enrollmentDate " +
                               "WHERE EnrollmentID = @id;";

                DatabaseHelper db = new DatabaseHelper();
                if (db.ExecuteAction(query,
                    new MySqlParameter("@memberId", memberId),
                    new MySqlParameter("@classId", classId),
                    new MySqlParameter("@enrollmentDate", enrollmentDate),
                    new MySqlParameter("@id", selectedId)))
                {
                    MessageBox.Show("Enrollment updated successfully!");
                    dgvEnrollments.DataSource = db.ExecuteSelect("SELECT * FROM ENROLLMENT;");
                    ClearInputs();
                }
            }
        }

        private void btnDeleteEnrollment_Click(object sender, EventArgs e)
        {
            if (dgvEnrollments.SelectedRows.Count > 0)
            {
                string selectedId = dgvEnrollments.SelectedRows[0].Cells["EnrollmentID"].Value.ToString();
                DialogResult result = MessageBox.Show("Delete this enrollment record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    string query = "DELETE FROM ENROLLMENT WHERE EnrollmentID = @id;";
                    DatabaseHelper db = new DatabaseHelper();
                    if (db.ExecuteAction(query, new MySqlParameter("@id", selectedId)))
                    {
                        MessageBox.Show("Enrollment deleted!");
                        dgvEnrollments.DataSource = db.ExecuteSelect("SELECT * FROM ENROLLMENT;");
                        ClearInputs();
                    }
                }
            }
        }
        private void ClearInputs()
        {
            txtMemberID.Clear();
            txtClassID.Clear();
            dtpEnrollmentDate.Value = DateTime.Now; 
        }
        private void LoadReferenceLists()
        {
            DatabaseHelper db = new DatabaseHelper();

            dgvMemberReference.DataSource = db.ExecuteSelect("SELECT MemberID, FName AS 'First Name', LName AS 'Last Name' FROM MEMBER;");

            dgvClassReference.DataSource = db.ExecuteSelect("SELECT ClassID, ClassName AS 'Class', ScheduleDay AS 'Day' FROM CLASS;");
        }

        private void dgvMemberReference_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
        
                txtMemberID.Text = dgvMemberReference.Rows[e.RowIndex].Cells["MemberID"].Value.ToString();
            }
        }

        private void dgvClassReference_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
              
                txtClassID.Text = dgvClassReference.Rows[e.RowIndex].Cells["ClassID"].Value.ToString();
            }
        }
    }
}
