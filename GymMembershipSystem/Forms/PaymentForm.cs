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
    public partial class PaymentForm: Form
    {
        public PaymentForm()
        {
            InitializeComponent();
            UiTheme.Apply(this);
            LoadReferenceLists();
        }

        private void btnLoadPayments_Click(object sender, EventArgs e)
        {
            DatabaseHelper db = new DatabaseHelper();
            dgvPayments.DataSource = db.ExecuteSelect("SELECT * FROM PAYMENT;");
        }

        private void btnAddPayment_Click(object sender, EventArgs e)
        {
            string memberId = txtMemberID.Text;
            string planId = txtPlanID.Text;
            string amount = txtAmount.Text;

            string paymentDate = dtpPaymentDate.Value.ToString("yyyy-MM-dd HH:mm:ss");

            string query = "INSERT INTO PAYMENT (MemberID, PlanID, PaymentDate, Amount) " +
                           "VALUES (@memberId, @planId, @paymentDate, @amount);";

            DatabaseHelper db = new DatabaseHelper();
            if (db.ExecuteAction(query,
                new MySqlParameter("@memberId", memberId),
                new MySqlParameter("@planId", planId),
                new MySqlParameter("@paymentDate", paymentDate),
                new MySqlParameter("@amount", amount)))
            {
                MessageBox.Show("Payment logged successfully!");
                dgvPayments.DataSource = db.ExecuteSelect("SELECT * FROM PAYMENT;");
                ClearInputs();
            }
        }

        private void dgvPayments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPayments.Rows[e.RowIndex];
                txtMemberID.Text = row.Cells["MemberID"].Value.ToString();
                txtPlanID.Text = row.Cells["PlanID"].Value.ToString();
                txtAmount.Text = row.Cells["Amount"].Value.ToString();

                // Safely parse the exact date and time
                if (DateTime.TryParse(row.Cells["PaymentDate"].Value.ToString(), out DateTime pDate))
                {
                    dtpPaymentDate.Value = pDate;
                }
            }
        }

        private void btnUpdatePayment_Click(object sender, EventArgs e)
        {
            if (dgvPayments.SelectedRows.Count > 0)
            {
                string selectedId = dgvPayments.SelectedRows[0].Cells["PaymentID"].Value.ToString();

                string memberId = txtMemberID.Text;
                string planId = txtPlanID.Text;
                string amount = txtAmount.Text;
                string paymentDate = dtpPaymentDate.Value.ToString("yyyy-MM-dd HH:mm:ss");

                string query = "UPDATE PAYMENT SET " +
                               "MemberID = @memberId, PlanID = @planId, " +
                               "PaymentDate = @paymentDate, Amount = @amount " +
                               "WHERE PaymentID = @id;";

                DatabaseHelper db = new DatabaseHelper();
                if (db.ExecuteAction(query,
                    new MySqlParameter("@memberId", memberId),
                    new MySqlParameter("@planId", planId),
                    new MySqlParameter("@paymentDate", paymentDate),
                    new MySqlParameter("@amount", amount),
                    new MySqlParameter("@id", selectedId)))
                {
                    MessageBox.Show("Payment updated successfully!");
                    dgvPayments.DataSource = db.ExecuteSelect("SELECT * FROM PAYMENT;");
                    ClearInputs();
                }
            }
        }

        private void btnDeletePayment_Click(object sender, EventArgs e)
        {
            if (dgvPayments.SelectedRows.Count > 0)
            {
                string selectedId = dgvPayments.SelectedRows[0].Cells["PaymentID"].Value.ToString();
                DialogResult result = MessageBox.Show("Delete this payment record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    string query = "DELETE FROM PAYMENT WHERE PaymentID = @id;";
                    DatabaseHelper db = new DatabaseHelper();
                    if (db.ExecuteAction(query, new MySqlParameter("@id", selectedId)))
                    {
                        MessageBox.Show("Payment deleted!");
                        dgvPayments.DataSource = db.ExecuteSelect("SELECT * FROM PAYMENT;");
                        ClearInputs();
                    }
                }
            }
        }
        private void ClearInputs()
        {
            txtMemberID.Clear();
            txtPlanID.Clear();
            txtAmount.Clear();
            dtpPaymentDate.Value = DateTime.Now; // Resets the picker to current date/time
        }

        private void LoadReferenceLists()
        {
            DatabaseHelper db = new DatabaseHelper();

            // Load the Members into the top reference grid
            dgvMemberReference.DataSource = db.ExecuteSelect("SELECT MemberID, FName AS 'First Name', LName AS 'Last Name' FROM MEMBER;");

            // Load the Plans (and their price, which is helpful!) into the bottom reference grid
            dgvPlanReference.DataSource = db.ExecuteSelect("SELECT PlanID, PlanName AS 'Plan', MonthlyFee AS 'Price' FROM PLAN;");
        }

        private void dgvMemberReference_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Grabs the MemberID and drops it into your text box
                txtMemberID.Text = dgvMemberReference.Rows[e.RowIndex].Cells["MemberID"].Value.ToString();
            }
        }


        private void dgvPlanReference_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Grabs the PlanID and drops it into your text box
                txtPlanID.Text = dgvPlanReference.Rows[e.RowIndex].Cells["PlanID"].Value.ToString();

                // Bonus Pro-Tip: You can even auto-fill the Amount text box while you are at it!
                txtAmount.Text = dgvPlanReference.Rows[e.RowIndex].Cells["Price"].Value.ToString();
            }
        }
    }
}
