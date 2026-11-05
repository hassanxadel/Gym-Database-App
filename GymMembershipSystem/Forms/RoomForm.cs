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
    public partial class RoomForm : Form
    {
        public RoomForm()
        {
            InitializeComponent();
            UiTheme.Apply(this);
        }

        private void btnLoadRooms_Click(object sender, EventArgs e)
        {
            DatabaseHelper db = new DatabaseHelper();
            dgvRooms.DataSource = db.ExecuteSelect("SELECT * FROM ROOM;");
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            string roomName = txtRoomName.Text;
            string activity = txtActivity.Text;

            // Convert the NumericUpDown value to a string for the SQL query
            string capacity = nudCapacity.Value.ToString();

            string query = "INSERT INTO ROOM (RoomName, Activity, Capacity) " +
                           "VALUES (@roomName, @activity, @capacity);";

            DatabaseHelper db = new DatabaseHelper();
            if (db.ExecuteAction(query,
                new MySqlParameter("@roomName", roomName),
                new MySqlParameter("@activity", activity),
                new MySqlParameter("@capacity", capacity)))
            {
                MessageBox.Show("Room added successfully!");
                dgvRooms.DataSource = db.ExecuteSelect("SELECT * FROM ROOM;");
                ClearInputs();
            }
        }

        private void dgvRooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvRooms.Rows[e.RowIndex];
                txtRoomName.Text = row.Cells["RoomName"].Value.ToString();
                txtActivity.Text = row.Cells["Activity"].Value.ToString();

                // Convert the SQL integer back into the NumericUpDown
                if (decimal.TryParse(row.Cells["Capacity"].Value.ToString(), out decimal cap))
                {
                    nudCapacity.Value = cap;
                }
            }
        }

        private void btnUpdateRoom_Click(object sender, EventArgs e)
        {
            if (dgvRooms.SelectedRows.Count > 0)
            {
                string selectedId = dgvRooms.SelectedRows[0].Cells["RoomID"].Value.ToString();

                string roomName = txtRoomName.Text;
                string activity = txtActivity.Text;
                string capacity = nudCapacity.Value.ToString();

                string query = "UPDATE ROOM SET " +
                               "RoomName = @roomName, Activity = @activity, Capacity = @capacity " +
                               "WHERE RoomID = @id;";

                DatabaseHelper db = new DatabaseHelper();
                if (db.ExecuteAction(query,
                    new MySqlParameter("@roomName", roomName),
                    new MySqlParameter("@activity", activity),
                    new MySqlParameter("@capacity", capacity),
                    new MySqlParameter("@id", selectedId)))
                {
                    MessageBox.Show("Room updated successfully!");
                    dgvRooms.DataSource = db.ExecuteSelect("SELECT * FROM ROOM;");
                    ClearInputs();
                }
            }
        }

        private void btnDeleteRoom_Click(object sender, EventArgs e)
        {
            if (dgvRooms.SelectedRows.Count > 0)
            {
                string selectedId = dgvRooms.SelectedRows[0].Cells["RoomID"].Value.ToString();
                DialogResult result = MessageBox.Show("Delete this room?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    string query = "DELETE FROM ROOM WHERE RoomID = @id;";
                    DatabaseHelper db = new DatabaseHelper();
                    if (db.ExecuteAction(query, new MySqlParameter("@id", selectedId)))
                    {
                        MessageBox.Show("Room deleted!");
                        dgvRooms.DataSource = db.ExecuteSelect("SELECT * FROM ROOM;");
                        ClearInputs();
                    }
                }
            }
        }
        private void ClearInputs()
        {
            txtRoomName.Clear();
            txtActivity.Clear();
            nudCapacity.Value = nudCapacity.Minimum; 
        }
    }
}
