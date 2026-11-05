namespace GymMembershipSystem.Forms
{
    partial class ClassForm
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
            this.btnUpdateClass = new System.Windows.Forms.Button();
            this.btnDeleteClass = new System.Windows.Forms.Button();
            this.btnAddClass = new System.Windows.Forms.Button();
            this.txtRoomID = new System.Windows.Forms.TextBox();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtTrainerID = new System.Windows.Forms.TextBox();
            this.Last_Name = new System.Windows.Forms.Label();
            this.First_Name = new System.Windows.Forms.Label();
            this.dob = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoadClasses = new System.Windows.Forms.Button();
            this.dgvClasses = new System.Windows.Forms.DataGridView();
            this.cmbScheduleDay = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvTrainerReference = new System.Windows.Forms.DataGridView();
            this.dgvRoomReference = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainerReference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomReference)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdateClass
            // 
            this.btnUpdateClass.Location = new System.Drawing.Point(334, 313);
            this.btnUpdateClass.Name = "btnUpdateClass";
            this.btnUpdateClass.Size = new System.Drawing.Size(111, 60);
            this.btnUpdateClass.TabIndex = 37;
            this.btnUpdateClass.Text = "Update Class";
            this.btnUpdateClass.UseVisualStyleBackColor = true;
            this.btnUpdateClass.Click += new System.EventHandler(this.btnUpdateClass_Click);
            // 
            // btnDeleteClass
            // 
            this.btnDeleteClass.Location = new System.Drawing.Point(334, 247);
            this.btnDeleteClass.Name = "btnDeleteClass";
            this.btnDeleteClass.Size = new System.Drawing.Size(111, 60);
            this.btnDeleteClass.TabIndex = 36;
            this.btnDeleteClass.Text = "Delete Class";
            this.btnDeleteClass.UseVisualStyleBackColor = true;
            this.btnDeleteClass.Click += new System.EventHandler(this.btnDeleteClass_Click);
            // 
            // btnAddClass
            // 
            this.btnAddClass.Location = new System.Drawing.Point(334, 181);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Size = new System.Drawing.Size(111, 60);
            this.btnAddClass.TabIndex = 35;
            this.btnAddClass.Text = "Add Class";
            this.btnAddClass.UseVisualStyleBackColor = true;
            this.btnAddClass.Click += new System.EventHandler(this.btnAddClass_Click);
            // 
            // txtRoomID
            // 
            this.txtRoomID.Location = new System.Drawing.Point(118, 223);
            this.txtRoomID.Name = "txtRoomID";
            this.txtRoomID.Size = new System.Drawing.Size(200, 22);
            this.txtRoomID.TabIndex = 32;
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(118, 262);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(200, 22);
            this.txtClassName.TabIndex = 31;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(118, 302);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(200, 22);
            this.txtDescription.TabIndex = 30;
            // 
            // txtTrainerID
            // 
            this.txtTrainerID.Location = new System.Drawing.Point(118, 185);
            this.txtTrainerID.Name = "txtTrainerID";
            this.txtTrainerID.Size = new System.Drawing.Size(200, 22);
            this.txtTrainerID.TabIndex = 29;
            // 
            // Last_Name
            // 
            this.Last_Name.AutoSize = true;
            this.Last_Name.Location = new System.Drawing.Point(12, 226);
            this.Last_Name.Name = "Last_Name";
            this.Last_Name.Size = new System.Drawing.Size(60, 16);
            this.Last_Name.TabIndex = 28;
            this.Last_Name.Text = "Room ID";
            // 
            // First_Name
            // 
            this.First_Name.AutoSize = true;
            this.First_Name.Location = new System.Drawing.Point(12, 188);
            this.First_Name.Name = "First_Name";
            this.First_Name.Size = new System.Drawing.Size(66, 16);
            this.First_Name.TabIndex = 27;
            this.First_Name.Text = "Trainer ID";
            // 
            // dob
            // 
            this.dob.AutoSize = true;
            this.dob.Location = new System.Drawing.Point(12, 305);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(75, 16);
            this.dob.TabIndex = 25;
            this.dob.Text = "Description";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(12, 265);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(81, 16);
            this.Email.TabIndex = 23;
            this.Email.Text = "Class Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 21;
            // 
            // btnLoadClasses
            // 
            this.btnLoadClasses.AccessibleName = "";
            this.btnLoadClasses.Location = new System.Drawing.Point(334, 383);
            this.btnLoadClasses.Name = "btnLoadClasses";
            this.btnLoadClasses.Size = new System.Drawing.Size(111, 60);
            this.btnLoadClasses.TabIndex = 20;
            this.btnLoadClasses.Text = "Load Classes";
            this.btnLoadClasses.UseVisualStyleBackColor = true;
            this.btnLoadClasses.Click += new System.EventHandler(this.btnLoadClasses_Click);
            // 
            // dgvClasses
            // 
            this.dgvClasses.AccessibleName = "dgvData";
            this.dgvClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClasses.Location = new System.Drawing.Point(12, 12);
            this.dgvClasses.Name = "dgvClasses";
            this.dgvClasses.RowHeadersWidth = 51;
            this.dgvClasses.RowTemplate.Height = 24;
            this.dgvClasses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClasses.Size = new System.Drawing.Size(776, 163);
            this.dgvClasses.TabIndex = 19;
            this.dgvClasses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClasses_CellClick);
            // 
            // cmbScheduleDay
            // 
            this.cmbScheduleDay.FormattingEnabled = true;
            this.cmbScheduleDay.Items.AddRange(new object[] {
            "Saturday",
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday"});
            this.cmbScheduleDay.Location = new System.Drawing.Point(118, 340);
            this.cmbScheduleDay.Name = "cmbScheduleDay";
            this.cmbScheduleDay.Size = new System.Drawing.Size(200, 24);
            this.cmbScheduleDay.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 383);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 39;
            this.label3.Text = "Start Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 41;
            this.label4.Text = "Schedule Day";
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpStartTime.Location = new System.Drawing.Point(118, 381);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.Size = new System.Drawing.Size(200, 22);
            this.dtpStartTime.TabIndex = 42;
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEndTime.Location = new System.Drawing.Point(118, 419);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.Size = new System.Drawing.Size(200, 22);
            this.dtpEndTime.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 422);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 44;
            this.label5.Text = "End Time";
            // 
            // dgvTrainerReference
            // 
            this.dgvTrainerReference.AllowUserToAddRows = false;
            this.dgvTrainerReference.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrainerReference.Location = new System.Drawing.Point(451, 181);
            this.dgvTrainerReference.Name = "dgvTrainerReference";
            this.dgvTrainerReference.ReadOnly = true;
            this.dgvTrainerReference.RowHeadersWidth = 51;
            this.dgvTrainerReference.RowTemplate.Height = 24;
            this.dgvTrainerReference.Size = new System.Drawing.Size(337, 126);
            this.dgvTrainerReference.TabIndex = 45;
            this.dgvTrainerReference.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTrainerReference_CellDoubleClick);
            // 
            // dgvRoomReference
            // 
            this.dgvRoomReference.AllowUserToAddRows = false;
            this.dgvRoomReference.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoomReference.Location = new System.Drawing.Point(451, 313);
            this.dgvRoomReference.Name = "dgvRoomReference";
            this.dgvRoomReference.ReadOnly = true;
            this.dgvRoomReference.RowHeadersWidth = 51;
            this.dgvRoomReference.RowTemplate.Height = 24;
            this.dgvRoomReference.Size = new System.Drawing.Size(337, 130);
            this.dgvRoomReference.TabIndex = 46;
            this.dgvRoomReference.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoomReference_CellDoubleClick);
            // 
            // ClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvRoomReference);
            this.Controls.Add(this.dgvTrainerReference);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpEndTime);
            this.Controls.Add(this.dtpStartTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbScheduleDay);
            this.Controls.Add(this.btnUpdateClass);
            this.Controls.Add(this.btnDeleteClass);
            this.Controls.Add(this.btnAddClass);
            this.Controls.Add(this.txtRoomID);
            this.Controls.Add(this.txtClassName);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtTrainerID);
            this.Controls.Add(this.Last_Name);
            this.Controls.Add(this.First_Name);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLoadClasses);
            this.Controls.Add(this.dgvClasses);
            this.Name = "ClassForm";
            this.Text = "Manage Classes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainerReference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomReference)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateClass;
        private System.Windows.Forms.Button btnDeleteClass;
        private System.Windows.Forms.Button btnAddClass;
        private System.Windows.Forms.TextBox txtRoomID;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtTrainerID;
        private System.Windows.Forms.Label Last_Name;
        private System.Windows.Forms.Label First_Name;
        private System.Windows.Forms.Label dob;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoadClasses;
        private System.Windows.Forms.DataGridView dgvClasses;
        private System.Windows.Forms.ComboBox cmbScheduleDay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvTrainerReference;
        private System.Windows.Forms.DataGridView dgvRoomReference;
    }
}