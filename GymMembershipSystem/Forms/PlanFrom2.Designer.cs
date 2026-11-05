namespace GymMembershipSystem.Forms
{
    partial class PlanFrom2
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
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtPlanName = new System.Windows.Forms.TextBox();
            this.btnDeletePlan = new System.Windows.Forms.Button();
            this.btnUpdatePlan = new System.Windows.Forms.Button();
            this.btnAddPlan = new System.Windows.Forms.Button();
            this.btnLoadPlans = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPlans = new System.Windows.Forms.DataGridView();
            this.nudMonthlyFee = new System.Windows.Forms.NumericUpDown();
            this.nudDurationDays = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonthlyFee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDurationDays)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(132, 235);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(200, 22);
            this.txtDescription.TabIndex = 31;
            // 
            // txtPlanName
            // 
            this.txtPlanName.Location = new System.Drawing.Point(132, 206);
            this.txtPlanName.Name = "txtPlanName";
            this.txtPlanName.Size = new System.Drawing.Size(200, 22);
            this.txtPlanName.TabIndex = 29;
            // 
            // btnDeletePlan
            // 
            this.btnDeletePlan.Location = new System.Drawing.Point(418, 380);
            this.btnDeletePlan.Name = "btnDeletePlan";
            this.btnDeletePlan.Size = new System.Drawing.Size(162, 58);
            this.btnDeletePlan.TabIndex = 28;
            this.btnDeletePlan.Text = "Delete Plan";
            this.btnDeletePlan.UseVisualStyleBackColor = true;
            this.btnDeletePlan.Click += new System.EventHandler(this.btnDeletePlan_Click);
            // 
            // btnUpdatePlan
            // 
            this.btnUpdatePlan.Location = new System.Drawing.Point(215, 380);
            this.btnUpdatePlan.Name = "btnUpdatePlan";
            this.btnUpdatePlan.Size = new System.Drawing.Size(162, 58);
            this.btnUpdatePlan.TabIndex = 27;
            this.btnUpdatePlan.Text = "Update Plan";
            this.btnUpdatePlan.UseVisualStyleBackColor = true;
            this.btnUpdatePlan.Click += new System.EventHandler(this.btnUpdatePlan_Click);
            // 
            // btnAddPlan
            // 
            this.btnAddPlan.Location = new System.Drawing.Point(12, 380);
            this.btnAddPlan.Name = "btnAddPlan";
            this.btnAddPlan.Size = new System.Drawing.Size(162, 58);
            this.btnAddPlan.TabIndex = 26;
            this.btnAddPlan.Text = "Add Plan";
            this.btnAddPlan.UseVisualStyleBackColor = true;
            this.btnAddPlan.Click += new System.EventHandler(this.btnAddPlan_Click);
            // 
            // btnLoadPlans
            // 
            this.btnLoadPlans.Location = new System.Drawing.Point(626, 380);
            this.btnLoadPlans.Name = "btnLoadPlans";
            this.btnLoadPlans.Size = new System.Drawing.Size(162, 58);
            this.btnLoadPlans.TabIndex = 25;
            this.btnLoadPlans.Text = "Load Plans";
            this.btnLoadPlans.UseVisualStyleBackColor = true;
            this.btnLoadPlans.Click += new System.EventHandler(this.btnLoadPlans_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "DurationDays";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Monthly Fee";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Plan Name";
            // 
            // dgvPlans
            // 
            this.dgvPlans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlans.Location = new System.Drawing.Point(12, 12);
            this.dgvPlans.Name = "dgvPlans";
            this.dgvPlans.RowHeadersWidth = 51;
            this.dgvPlans.RowTemplate.Height = 24;
            this.dgvPlans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlans.Size = new System.Drawing.Size(776, 175);
            this.dgvPlans.TabIndex = 19;
            this.dgvPlans.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlans_CellClick);
            // 
            // nudMonthlyFee
            // 
            this.nudMonthlyFee.DecimalPlaces = 2;
            this.nudMonthlyFee.Location = new System.Drawing.Point(132, 313);
            this.nudMonthlyFee.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudMonthlyFee.Name = "nudMonthlyFee";
            this.nudMonthlyFee.Size = new System.Drawing.Size(200, 22);
            this.nudMonthlyFee.TabIndex = 33;
            // 
            // nudDurationDays
            // 
            this.nudDurationDays.Location = new System.Drawing.Point(132, 345);
            this.nudDurationDays.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.nudDurationDays.Name = "nudDurationDays";
            this.nudDurationDays.Size = new System.Drawing.Size(200, 22);
            this.nudDurationDays.TabIndex = 34;
            // 
            // PlanFrom2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nudDurationDays);
            this.Controls.Add(this.nudMonthlyFee);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtPlanName);
            this.Controls.Add(this.btnDeletePlan);
            this.Controls.Add(this.btnUpdatePlan);
            this.Controls.Add(this.btnAddPlan);
            this.Controls.Add(this.btnLoadPlans);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPlans);
            this.Name = "PlanFrom2";
            this.Text = "PlanFrom2";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonthlyFee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDurationDays)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtPlanName;
        private System.Windows.Forms.Button btnDeletePlan;
        private System.Windows.Forms.Button btnUpdatePlan;
        private System.Windows.Forms.Button btnAddPlan;
        private System.Windows.Forms.Button btnLoadPlans;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPlans;
        private System.Windows.Forms.NumericUpDown nudMonthlyFee;
        private System.Windows.Forms.NumericUpDown nudDurationDays;
    }
}