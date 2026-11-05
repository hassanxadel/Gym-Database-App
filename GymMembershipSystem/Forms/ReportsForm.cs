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
    public partial class ReportsForm: Form
    {
        public ReportsForm()
        {
            InitializeComponent();
            UiTheme.Apply(this);
        }

        private void btnMemberHistory_Click(object sender, EventArgs e)
        {
            DatabaseHelper db = new DatabaseHelper();

            // This string perfectly matches the procedure you just created in File 3!
            string query = "CALL GetMemberPaymentHistory();";

            // This executes the procedure and pushes the results into your grid
            dgvReports.DataSource = db.ExecuteSelect(query);
        }

        private void btnRevenueReport_Click(object sender, EventArgs e)
        {
            // This query explicitly uses GROUP BY and aggregate functions(COUNT and SUM)
    string query = @"SELECT p.PlanName AS 'Membership Plan', 
                            COUNT(pay.PaymentID) AS 'Total Subscribers', 
                            SUM(pay.Amount) AS 'Total Revenue Generated'
                     FROM PLAN p
                     LEFT JOIN PAYMENT pay ON p.PlanID = pay.PlanID
                     GROUP BY p.PlanID, p.PlanName;";

            DatabaseHelper db = new DatabaseHelper();
            dgvReports.DataSource = db.ExecuteSelect(query);
        }
    }
}
