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
    public partial class ClassForm : Form
    {
        public ClassForm()
        {
            InitializeComponent();
            LoadReferenceLists();
        }

        private void btnLoadClasses_Click(object sender, EventArgs e)
        {
            DatabaseHelper db = new DatabaseHelper();
            dgvClasses.DataSource = db.ExecuteSelect("SELECT * FROM CLASS;");

        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            string trainerId = txtTrainerID.Text;
            string roomId = txtRoomID.Text;
            string className = txtClassName.Text;
            string description = txtDescription.Text;
            string scheduleDay = cmbScheduleDay.Text;

            // Format specifically for MySQL TIME data type
            string startTime = dtpStartTime.Value.ToString("HH:mm:ss");
            string endTime = dtpEndTime.Value.ToString("HH:mm:ss");

            string query = $"INSERT INTO CLASS (TrainerID, RoomID, ClassName, Description, ScheduleDay, StartTime, EndTime) " +
                           $"VALUES ({trainerId}, {roomId}, '{className}', '{description}', '{scheduleDay}', '{startTime}', '{endTime}');";

            DatabaseHelper db = new DatabaseHelper();
            if (db.ExecuteAction(query))
            {
                MessageBox.Show("Class added successfully!");
                dgvClasses.DataSource = db.ExecuteSelect("SELECT * FROM CLASS;");
                ClearInputs();
            }
        }

        private void dgvClasses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvClasses.Rows[e.RowIndex];
                txtTrainerID.Text = row.Cells["TrainerID"].Value.ToString();
                txtRoomID.Text = row.Cells["RoomID"].Value.ToString();
                txtClassName.Text = row.Cells["ClassName"].Value.ToString();
                txtDescription.Text = row.Cells["Description"].Value.ToString();
                cmbScheduleDay.Text = row.Cells["ScheduleDay"].Value.ToString();

                // Convert the SQL time string back into the DateTimePickers
                if (DateTime.TryParse(row.Cells["StartTime"].Value.ToString(), out DateTime start))
                {
                    dtpStartTime.Value = start;
                }
                if (DateTime.TryParse(row.Cells["EndTime"].Value.ToString(), out DateTime end))
                {
                    dtpEndTime.Value = end;
                }
            }
        }

        private void btnUpdateClass_Click(object sender, EventArgs e)
        {
            if (dgvClasses.SelectedRows.Count > 0)
            {
                string selectedId = dgvClasses.SelectedRows[0].Cells["ClassID"].Value.ToString();

                string trainerId = txtTrainerID.Text;
                string roomId = txtRoomID.Text;
                string className = txtClassName.Text;
                string description = txtDescription.Text;
                string scheduleDay = cmbScheduleDay.Text;
                string startTime = dtpStartTime.Value.ToString("HH:mm:ss");
                string endTime = dtpEndTime.Value.ToString("HH:mm:ss");

                string query = $"UPDATE CLASS SET " +
                               $"TrainerID = {trainerId}, RoomID = {roomId}, ClassName = '{className}', " +
                               $"Description = '{description}', ScheduleDay = '{scheduleDay}', " +
                               $"StartTime = '{startTime}', EndTime = '{endTime}' " +
                               $"WHERE ClassID = {selectedId};";

                DatabaseHelper db = new DatabaseHelper();
                if (db.ExecuteAction(query))
                {
                    MessageBox.Show("Class updated successfully!");
                    dgvClasses.DataSource = db.ExecuteSelect("SELECT * FROM CLASS;");
                    ClearInputs();
                }
            }
        }

        private void btnDeleteClass_Click(object sender, EventArgs e)
        {
            if (dgvClasses.SelectedRows.Count > 0)
            {
                string selectedId = dgvClasses.SelectedRows[0].Cells["ClassID"].Value.ToString();
                DialogResult result = MessageBox.Show("Delete this class?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    string query = $"DELETE FROM CLASS WHERE ClassID = {selectedId};";
                    DatabaseHelper db = new DatabaseHelper();
                    if (db.ExecuteAction(query))
                    {
                        MessageBox.Show("Class deleted!");
                        dgvClasses.DataSource = db.ExecuteSelect("SELECT * FROM CLASS;");
                        ClearInputs();
                    }
                }
            }
        }
            private void ClearInputs()
        {
            txtTrainerID.Clear();
            txtRoomID.Clear();
            txtClassName.Clear();
            txtDescription.Clear();
            cmbScheduleDay.SelectedIndex = -1;
        }
        private void LoadReferenceLists()
        {
            DatabaseHelper db = new DatabaseHelper();
            dgvTrainerReference.DataSource = db.ExecuteSelect("SELECT TrainerID, FName AS 'First Name', LName AS 'Last Name' FROM TRAINER;");
      
            dgvRoomReference.DataSource = db.ExecuteSelect("SELECT RoomID, RoomName AS 'Room' FROM ROOM;");
        }

        private void dgvTrainerReference_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTrainerID.Text = dgvTrainerReference.Rows[e.RowIndex].Cells["TrainerID"].Value.ToString();
        }

        private void dgvRoomReference_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtRoomID.Text = dgvRoomReference.Rows[e.RowIndex].Cells["RoomID"].Value.ToString();
        }
    }
    }

