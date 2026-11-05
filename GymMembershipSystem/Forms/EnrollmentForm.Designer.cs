namespace GymMembershipSystem.Forms
{
    partial class EnrollmentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtpEnrollmentDate = new System.Windows.Forms.DateTimePicker();
            this.btnUpdateEnrollment = new System.Windows.Forms.Button();
            this.btnDeleteEnrollment = new System.Windows.Forms.Button();
            this.btnAddEnrollment = new System.Windows.Forms.Button();
            this.txtClassID = new System.Windows.Forms.TextBox();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.Last_Name = new System.Windows.Forms.Label();
            this.First_Name = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoadEnrollments = new System.Windows.Forms.Button();
            this.dgvEnrollments = new System.Windows.Forms.DataGridView();
            this.dgvMemberReference = new System.Windows.Forms.DataGridView();
            this.dgvClassReference = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnrollments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberReference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassReference)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpEnrollmentDate
            // 
            this.dtpEnrollmentDate.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpEnrollmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnrollmentDate.Location = new System.Drawing.Point(124, 309);
            this.dtpEnrollmentDate.Name = "dtpEnrollmentDate";
            this.dtpEnrollmentDate.Size = new System.Drawing.Size(200, 22);
            this.dtpEnrollmentDate.TabIndex = 81;
            // 
            // btnUpdateEnrollment
            // 
            this.btnUpdateEnrollment.Location = new System.Drawing.Point(181, 367);
            this.btnUpdateEnrollment.Name = "btnUpdateEnrollment";
            this.btnUpdateEnrollment.Size = new System.Drawing.Size(143, 71);
            this.btnUpdateEnrollment.TabIndex = 79;
            this.btnUpdateEnrollment.Text = "Update Enrollment";
            this.btnUpdateEnrollment.UseVisualStyleBackColor = true;
            this.btnUpdateEnrollment.Click += new System.EventHandler(this.btnUpdateEnrollment_Click);
            // 
            // btnDeleteEnrollment
            // 
            this.btnDeleteEnrollment.Location = new System.Drawing.Point(337, 233);
            this.btnDeleteEnrollment.Name = "btnDeleteEnrollment";
            this.btnDeleteEnrollment.Size = new System.Drawing.Size(143, 71);
            this.btnDeleteEnrollment.TabIndex = 78;
            this.btnDeleteEnrollment.Text = "Delete Enrollment";
            this.btnDeleteEnrollment.UseVisualStyleBackColor = true;
            this.btnDeleteEnrollment.Click += new System.EventHandler(this.btnDeleteEnrollment_Click);
            // 
            // btnAddEnrollment
            // 
            this.btnAddEnrollment.Location = new System.Drawing.Point(15, 367);
            this.btnAddEnrollment.Name = "btnAddEnrollment";
            this.btnAddEnrollment.Size = new System.Drawing.Size(143, 71);
            this.btnAddEnrollment.TabIndex = 77;
            this.btnAddEnrollment.Text = "Add Enrollment";
            this.btnAddEnrollment.UseVisualStyleBackColor = true;
            this.btnAddEnrollment.Click += new System.EventHandler(this.btnAddEnrollment_Click);
            // 
            // txtClassID
            // 
            this.txtClassID.Location = new System.Drawing.Point(124, 270);
            this.txtClassID.Name = "txtClassID";
            this.txtClassID.Size = new System.Drawing.Size(200, 22);
            this.txtClassID.TabIndex = 76;
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(124, 233);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(200, 22);
            this.txtMemberID.TabIndex = 75;
            // 
            // Last_Name
            // 
            this.Last_Name.AutoSize = true;
            this.Last_Name.Location = new System.Drawing.Point(12, 276);
            this.Last_Name.Name = "Last_Name";
            this.Last_Name.Size = new System.Drawing.Size(57, 16);
            this.Last_Name.TabIndex = 74;
            this.Last_Name.Text = "Class ID";
            // 
            // First_Name
            // 
            this.First_Name.AutoSize = true;
            this.First_Name.Location = new System.Drawing.Point(12, 239);
            this.First_Name.Name = "First_Name";
            this.First_Name.Size = new System.Drawing.Size(73, 16);
            this.First_Name.TabIndex = 73;
            this.First_Name.Text = "Member ID";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(12, 315);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(102, 16);
            this.Email.TabIndex = 72;
            this.Email.Text = "Enrollment Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 71;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 70;
            // 
            // btnLoadEnrollments
            // 
            this.btnLoadEnrollments.AccessibleName = "";
            this.btnLoadEnrollments.Location = new System.Drawing.Point(339, 367);
            this.btnLoadEnrollments.Name = "btnLoadEnrollments";
            this.btnLoadEnrollments.Size = new System.Drawing.Size(143, 71);
            this.btnLoadEnrollments.TabIndex = 69;
            this.btnLoadEnrollments.Text = "Load Enrollments";
            this.btnLoadEnrollments.UseVisualStyleBackColor = true;
            this.btnLoadEnrollments.Click += new System.EventHandler(this.btnLoadEnrollments_Click);
            // 
            // dgvEnrollments
            // 
            this.dgvEnrollments.AccessibleName = "dgvData";
            this.dgvEnrollments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnrollments.Location = new System.Drawing.Point(14, 12);
            this.dgvEnrollments.Name = "dgvEnrollments";
            this.dgvEnrollments.RowHeadersWidth = 51;
            this.dgvEnrollments.RowTemplate.Height = 24;
            this.dgvEnrollments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEnrollments.Size = new System.Drawing.Size(776, 178);
            this.dgvEnrollments.TabIndex = 68;
            this.dgvEnrollments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEnrollments_CellClick);
            // 
            // dgvMemberReference
            // 
            this.dgvMemberReference.AllowUserToAddRows = false;
            this.dgvMemberReference.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMemberReference.Location = new System.Drawing.Point(486, 197);
            this.dgvMemberReference.Name = "dgvMemberReference";
            this.dgvMemberReference.ReadOnly = true;
            this.dgvMemberReference.RowHeadersWidth = 51;
            this.dgvMemberReference.RowTemplate.Height = 24;
            this.dgvMemberReference.Size = new System.Drawing.Size(302, 123);
            this.dgvMemberReference.TabIndex = 82;
            this.dgvMemberReference.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMemberReference_CellDoubleClick);
            // 
            // dgvClassReference
            // 
            this.dgvClassReference.AllowUserToAddRows = false;
            this.dgvClassReference.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClassReference.Location = new System.Drawing.Point(486, 326);
            this.dgvClassReference.Name = "dgvClassReference";
            this.dgvClassReference.ReadOnly = true;
            this.dgvClassReference.RowHeadersWidth = 51;
            this.dgvClassReference.RowTemplate.Height = 24;
            this.dgvClassReference.Size = new System.Drawing.Size(302, 112);
            this.dgvClassReference.TabIndex = 83;
            this.dgvClassReference.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClassReference_CellDoubleClick);
            // 
            // EnrollmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvClassReference);
            this.Controls.Add(this.dgvMemberReference);
            this.Controls.Add(this.dtpEnrollmentDate);
            this.Controls.Add(this.btnUpdateEnrollment);
            this.Controls.Add(this.btnDeleteEnrollment);
            this.Controls.Add(this.btnAddEnrollment);
            this.Controls.Add(this.txtClassID);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.Last_Name);
            this.Controls.Add(this.First_Name);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLoadEnrollments);
            this.Controls.Add(this.dgvEnrollments);
            this.Name = "EnrollmentForm";
            this.Text = "EnrollmentForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnrollments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberReference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassReference)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpEnrollmentDate;
        private System.Windows.Forms.Button btnUpdateEnrollment;
        private System.Windows.Forms.Button btnDeleteEnrollment;
        private System.Windows.Forms.Button btnAddEnrollment;
        private System.Windows.Forms.TextBox txtClassID;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.Label Last_Name;
        private System.Windows.Forms.Label First_Name;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoadEnrollments;
        private System.Windows.Forms.DataGridView dgvEnrollments;
        private System.Windows.Forms.DataGridView dgvMemberReference;
        private System.Windows.Forms.DataGridView dgvClassReference;
    }
}