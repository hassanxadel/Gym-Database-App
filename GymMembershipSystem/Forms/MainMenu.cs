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
    public partial class MainMenu: Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
private void btnManageMembers_Click(object sender, EventArgs e)
        {
            // 1. Create an instance of your members form
            Form1 membersScreen = new Form1();

            // 2. Display the form to the user
            membersScreen.ShowDialog();
        }

        private void btnManageTrainers_Click(object sender, EventArgs e)
        {
            Forms.TrainerForm trainerScreen = new Forms.TrainerForm();
            trainerScreen.ShowDialog();
        }

        private void btnManageClasses_Click(object sender, EventArgs e)
        {
            Forms.ClassForm classScreen = new Forms.ClassForm();
            classScreen.ShowDialog();
        }

        private void btnManageRooms_Click(object sender, EventArgs e)
        {
            Forms.RoomForm roomScreen = new Forms.RoomForm();
            roomScreen.ShowDialog();
        }

        private void btnManagePayments_Click(object sender, EventArgs e)
        {
            Forms.PaymentForm paymentScreen = new Forms.PaymentForm();
            paymentScreen.ShowDialog();
        }

        private void Enrollments_Click(object sender, EventArgs e)
        {
            Forms.EnrollmentForm enrollmentScreen = new Forms.EnrollmentForm();
            enrollmentScreen.ShowDialog();
        }

        private void btnManagePlans_Click(object sender, EventArgs e)
        {
            Forms.PlanFrom2 planScreen = new Forms.PlanFrom2();
            planScreen.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            Forms.ReportsForm reportScreen = new Forms.ReportsForm();
            reportScreen.ShowDialog();

        }
    }
    }

