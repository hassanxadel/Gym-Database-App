namespace GymMembershipSystem.Forms
{
    partial class TrainerForm
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
            this.dgvTrainers = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLoadTrainers = new System.Windows.Forms.Button();
            this.btnAddTrainer = new System.Windows.Forms.Button();
            this.btnUpdateTrainer = new System.Windows.Forms.Button();
            this.btnDeleteTrainer = new System.Windows.Forms.Button();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.cmbLevel = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTrainers
            // 
            this.dgvTrainers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrainers.Location = new System.Drawing.Point(12, 12);
            this.dgvTrainers.Name = "dgvTrainers";
            this.dgvTrainers.RowHeadersWidth = 51;
            this.dgvTrainers.RowTemplate.Height = 24;
            this.dgvTrainers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTrainers.Size = new System.Drawing.Size(776, 175);
            this.dgvTrainers.TabIndex = 0;
            this.dgvTrainers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTrainers_CellClick_1);
            this.dgvTrainers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTrainers_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Level";
            // 
            // btnLoadTrainers
            // 
            this.btnLoadTrainers.Location = new System.Drawing.Point(625, 380);
            this.btnLoadTrainers.Name = "btnLoadTrainers";
            this.btnLoadTrainers.Size = new System.Drawing.Size(128, 58);
            this.btnLoadTrainers.TabIndex = 8;
            this.btnLoadTrainers.Text = "Load Trainers";
            this.btnLoadTrainers.UseVisualStyleBackColor = true;
            this.btnLoadTrainers.Click += new System.EventHandler(this.btnLoadTrainers_Click);
            // 
            // btnAddTrainer
            // 
            this.btnAddTrainer.Location = new System.Drawing.Point(30, 380);
            this.btnAddTrainer.Name = "btnAddTrainer";
            this.btnAddTrainer.Size = new System.Drawing.Size(128, 58);
            this.btnAddTrainer.TabIndex = 9;
            this.btnAddTrainer.Text = "Add Trainer";
            this.btnAddTrainer.UseVisualStyleBackColor = true;
            this.btnAddTrainer.Click += new System.EventHandler(this.btnAddTrainer_Click_1);
            // 
            // btnUpdateTrainer
            // 
            this.btnUpdateTrainer.Location = new System.Drawing.Point(226, 380);
            this.btnUpdateTrainer.Name = "btnUpdateTrainer";
            this.btnUpdateTrainer.Size = new System.Drawing.Size(128, 58);
            this.btnUpdateTrainer.TabIndex = 10;
            this.btnUpdateTrainer.Text = "Update Trainer";
            this.btnUpdateTrainer.UseVisualStyleBackColor = true;
            this.btnUpdateTrainer.Click += new System.EventHandler(this.btnUpdateTrainer_Click_1);
            // 
            // btnDeleteTrainer
            // 
            this.btnDeleteTrainer.Location = new System.Drawing.Point(415, 380);
            this.btnDeleteTrainer.Name = "btnDeleteTrainer";
            this.btnDeleteTrainer.Size = new System.Drawing.Size(128, 58);
            this.btnDeleteTrainer.TabIndex = 11;
            this.btnDeleteTrainer.Text = "Delete Trainer";
            this.btnDeleteTrainer.UseVisualStyleBackColor = true;
            this.btnDeleteTrainer.Click += new System.EventHandler(this.btnDeleteTrainer_Click_1);
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(136, 206);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(200, 22);
            this.txtFName.TabIndex = 12;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(136, 264);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 22);
            this.txtEmail.TabIndex = 13;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(136, 235);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(200, 22);
            this.txtLName.TabIndex = 14;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(136, 292);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(200, 22);
            this.txtPhone.TabIndex = 15;
            // 
            // cmbLevel
            // 
            this.cmbLevel.FormattingEnabled = true;
            this.cmbLevel.Items.AddRange(new object[] {
            "Junior",
            "Mid-Level",
            "Senior",
            "Pro"});
            this.cmbLevel.Location = new System.Drawing.Point(136, 321);
            this.cmbLevel.Name = "cmbLevel";
            this.cmbLevel.Size = new System.Drawing.Size(200, 24);
            this.cmbLevel.TabIndex = 18;
            // 
            // TrainerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbLevel);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.btnDeleteTrainer);
            this.Controls.Add(this.btnUpdateTrainer);
            this.Controls.Add(this.btnAddTrainer);
            this.Controls.Add(this.btnLoadTrainers);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTrainers);
            this.Name = "TrainerForm";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTrainers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLoadTrainers;
        private System.Windows.Forms.Button btnAddTrainer;
        private System.Windows.Forms.Button btnUpdateTrainer;
        private System.Windows.Forms.Button btnDeleteTrainer;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.ComboBox cmbLevel;
    }
}