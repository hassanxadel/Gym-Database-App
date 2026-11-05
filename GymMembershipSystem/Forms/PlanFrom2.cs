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
    public partial class PlanFrom2: Form
    {
        public PlanFrom2()
        {
            InitializeComponent();
            UiTheme.Apply(this);
        }

        private void btnAddPlan_Click(object sender, EventArgs e)
        {
            string planName = txtPlanName.Text;
            string description = txtDescription.Text;
            string monthlyFee = nudMonthlyFee.Value.ToString();
            string durationDays = nudDurationDays.Value.ToString();

            string query = "INSERT INTO PLAN (PlanName, Description, MonthlyFee, DurationDays) " +
                           "VALUES (@planName, @description, @monthlyFee, @durationDays);";

            DatabaseHelper db = new DatabaseHelper();
            if (db.ExecuteAction(query,
                new MySqlParameter("@planName", planName),
                new MySqlParameter("@description", description),
                new MySqlParameter("@monthlyFee", monthlyFee),
                new MySqlParameter("@durationDays", durationDays)))
            {
                MessageBox.Show("Plan added successfully!");
                dgvPlans.DataSource = db.ExecuteSelect("SELECT * FROM PLAN;");
                ClearInputs();
            }
        }

        private void btnLoadPlans_Click(object sender, EventArgs e)
        {
            DatabaseHelper db = new DatabaseHelper();
            dgvPlans.DataSource = db.ExecuteSelect("SELECT * FROM PLAN;");
        }

        private void dgvPlans_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPlans.Rows[e.RowIndex];
                txtPlanName.Text = row.Cells["PlanName"].Value.ToString();
                txtDescription.Text = row.Cells["Description"].Value.ToString();

                // Safely parse the decimals back into the NumericUpDown boxes
                if (decimal.TryParse(row.Cells["MonthlyFee"].Value.ToString(), out decimal fee))
                {
                    nudMonthlyFee.Value = fee;
                }
                if (decimal.TryParse(row.Cells["DurationDays"].Value.ToString(), out decimal days))
                {
                    nudDurationDays.Value = days;
                }
            }
        }

        private void btnUpdatePlan_Click(object sender, EventArgs e)
        {
            if (dgvPlans.SelectedRows.Count > 0)
            {
                string selectedId = dgvPlans.SelectedRows[0].Cells["PlanID"].Value.ToString();

                string planName = txtPlanName.Text;
                string description = txtDescription.Text;
                string monthlyFee = nudMonthlyFee.Value.ToString();
                string durationDays = nudDurationDays.Value.ToString();

                string query = "UPDATE PLAN SET " +
                               "PlanName = @planName, Description = @description, " +
                               "MonthlyFee = @monthlyFee, DurationDays = @durationDays " +
                               "WHERE PlanID = @id;";

                DatabaseHelper db = new DatabaseHelper();
                if (db.ExecuteAction(query,
                    new MySqlParameter("@planName", planName),
                    new MySqlParameter("@description", description),
                    new MySqlParameter("@monthlyFee", monthlyFee),
                    new MySqlParameter("@durationDays", durationDays),
                    new MySqlParameter("@id", selectedId)))
                {
                    MessageBox.Show("Plan updated successfully!");
                    dgvPlans.DataSource = db.ExecuteSelect("SELECT * FROM PLAN;");
                    ClearInputs();
                }
            }
        }

        private void btnDeletePlan_Click(object sender, EventArgs e)
        {
            if (dgvPlans.SelectedRows.Count > 0)
            {
                string selectedId = dgvPlans.SelectedRows[0].Cells["PlanID"].Value.ToString();
                DialogResult result = MessageBox.Show("Delete this membership plan?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    string query = "DELETE FROM PLAN WHERE PlanID = @id;";
                    DatabaseHelper db = new DatabaseHelper();
                    if (db.ExecuteAction(query, new MySqlParameter("@id", selectedId)))
                    {
                        MessageBox.Show("Plan deleted!");
                        dgvPlans.DataSource = db.ExecuteSelect("SELECT * FROM PLAN;");
                        ClearInputs();
                    }
                }
            }
        }
        private void ClearInputs()
        {
            txtPlanName.Clear();
            txtDescription.Clear();
            nudMonthlyFee.Value = nudMonthlyFee.Minimum;
            nudDurationDays.Value = nudDurationDays.Minimum;
        }

    }
}
