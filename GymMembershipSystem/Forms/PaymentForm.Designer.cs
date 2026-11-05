namespace GymMembershipSystem.Forms
{
    partial class PaymentForm
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
            this.btnUpdatePayment = new System.Windows.Forms.Button();
            this.btnDeletePayment = new System.Windows.Forms.Button();
            this.btnAddPayment = new System.Windows.Forms.Button();
            this.txtPlanID = new System.Windows.Forms.TextBox();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.Last_Name = new System.Windows.Forms.Label();
            this.First_Name = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoadPayments = new System.Windows.Forms.Button();
            this.dgvPayments = new System.Windows.Forms.DataGridView();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.dtpPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvMemberReference = new System.Windows.Forms.DataGridView();
            this.dgvPlanReference = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberReference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanReference)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdatePayment
            // 
            this.btnUpdatePayment.Location = new System.Drawing.Point(182, 367);
            this.btnUpdatePayment.Name = "btnUpdatePayment";
            this.btnUpdatePayment.Size = new System.Drawing.Size(142, 71);
            this.btnUpdatePayment.TabIndex = 63;
            this.btnUpdatePayment.Text = "Update Payment";
            this.btnUpdatePayment.UseVisualStyleBackColor = true;
            this.btnUpdatePayment.Click += new System.EventHandler(this.btnUpdatePayment_Click);
            // 
            // btnDeletePayment
            // 
            this.btnDeletePayment.Location = new System.Drawing.Point(330, 285);
            this.btnDeletePayment.Name = "btnDeletePayment";
            this.btnDeletePayment.Size = new System.Drawing.Size(142, 71);
            this.btnDeletePayment.TabIndex = 62;
            this.btnDeletePayment.Text = "Delete Payment";
            this.btnDeletePayment.UseVisualStyleBackColor = true;
            this.btnDeletePayment.Click += new System.EventHandler(this.btnDeletePayment_Click);
            // 
            // btnAddPayment
            // 
            this.btnAddPayment.Location = new System.Drawing.Point(15, 367);
            this.btnAddPayment.Name = "btnAddPayment";
            this.btnAddPayment.Size = new System.Drawing.Size(142, 71);
            this.btnAddPayment.TabIndex = 61;
            this.btnAddPayment.Text = "Add Payment";
            this.btnAddPayment.UseVisualStyleBackColor = true;
            this.btnAddPayment.Click += new System.EventHandler(this.btnAddPayment_Click);
            // 
            // txtPlanID
            // 
            this.txtPlanID.Location = new System.Drawing.Point(124, 252);
            this.txtPlanID.Name = "txtPlanID";
            this.txtPlanID.Size = new System.Drawing.Size(200, 22);
            this.txtPlanID.TabIndex = 60;
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(124, 203);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(200, 22);
            this.txtMemberID.TabIndex = 59;
            // 
            // Last_Name
            // 
            this.Last_Name.AutoSize = true;
            this.Last_Name.Location = new System.Drawing.Point(12, 258);
            this.Last_Name.Name = "Last_Name";
            this.Last_Name.Size = new System.Drawing.Size(50, 16);
            this.Last_Name.TabIndex = 58;
            this.Last_Name.Text = "Plan ID";
            // 
            // First_Name
            // 
            this.First_Name.AutoSize = true;
            this.First_Name.Location = new System.Drawing.Point(12, 209);
            this.First_Name.Name = "First_Name";
            this.First_Name.Size = new System.Drawing.Size(81, 16);
            this.First_Name.TabIndex = 57;
            this.First_Name.Text = "Memeber ID";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(12, 302);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(52, 16);
            this.Email.TabIndex = 56;
            this.Email.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 54;
            // 
            // btnLoadPayments
            // 
            this.btnLoadPayments.AccessibleName = "";
            this.btnLoadPayments.Location = new System.Drawing.Point(330, 203);
            this.btnLoadPayments.Name = "btnLoadPayments";
            this.btnLoadPayments.Size = new System.Drawing.Size(142, 71);
            this.btnLoadPayments.TabIndex = 53;
            this.btnLoadPayments.Text = "Load Payment";
            this.btnLoadPayments.UseVisualStyleBackColor = true;
            this.btnLoadPayments.Click += new System.EventHandler(this.btnLoadPayments_Click);
            // 
            // dgvPayments
            // 
            this.dgvPayments.AccessibleName = "dgvData";
            this.dgvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayments.Location = new System.Drawing.Point(12, 12);
            this.dgvPayments.Name = "dgvPayments";
            this.dgvPayments.RowHeadersWidth = 51;
            this.dgvPayments.RowTemplate.Height = 24;
            this.dgvPayments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPayments.Size = new System.Drawing.Size(776, 178);
            this.dgvPayments.TabIndex = 52;
            this.dgvPayments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPayments_CellClick);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(124, 285);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(200, 22);
            this.txtAmount.TabIndex = 65;
            // 
            // dtpPaymentDate
            // 
            this.dtpPaymentDate.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPaymentDate.Location = new System.Drawing.Point(124, 334);
            this.dtpPaymentDate.Name = "dtpPaymentDate";
            this.dtpPaymentDate.Size = new System.Drawing.Size(200, 22);
            this.dtpPaymentDate.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 67;
            this.label3.Text = "Payment Date";
            // 
            // dgvMemberReference
            // 
            this.dgvMemberReference.AllowUserToAddRows = false;
            this.dgvMemberReference.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMemberReference.Location = new System.Drawing.Point(479, 203);
            this.dgvMemberReference.Name = "dgvMemberReference";
            this.dgvMemberReference.ReadOnly = true;
            this.dgvMemberReference.RowHeadersWidth = 51;
            this.dgvMemberReference.RowTemplate.Height = 24;
            this.dgvMemberReference.Size = new System.Drawing.Size(309, 115);
            this.dgvMemberReference.TabIndex = 68;
            this.dgvMemberReference.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMemberReference_CellDoubleClick);
            // 
            // dgvPlanReference
            // 
            this.dgvPlanReference.AllowUserToAddRows = false;
            this.dgvPlanReference.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlanReference.Location = new System.Drawing.Point(479, 324);
            this.dgvPlanReference.Name = "dgvPlanReference";
            this.dgvPlanReference.ReadOnly = true;
            this.dgvPlanReference.RowHeadersWidth = 51;
            this.dgvPlanReference.RowTemplate.Height = 24;
            this.dgvPlanReference.Size = new System.Drawing.Size(309, 115);
            this.dgvPlanReference.TabIndex = 69;

            this.dgvPlanReference.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlanReference_CellDoubleClick);
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvPlanReference);
            this.Controls.Add(this.dgvMemberReference);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpPaymentDate);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.btnUpdatePayment);
            this.Controls.Add(this.btnDeletePayment);
            this.Controls.Add(this.btnAddPayment);
            this.Controls.Add(this.txtPlanID);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.Last_Name);
            this.Controls.Add(this.First_Name);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLoadPayments);
            this.Controls.Add(this.dgvPayments);
            this.Name = "PaymentForm";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberReference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanReference)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUpdatePayment;
        private System.Windows.Forms.Button btnDeletePayment;
        private System.Windows.Forms.Button btnAddPayment;
        private System.Windows.Forms.TextBox txtPlanID;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.Label Last_Name;
        private System.Windows.Forms.Label First_Name;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoadPayments;
        private System.Windows.Forms.DataGridView dgvPayments;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.DateTimePicker dtpPaymentDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvMemberReference;
        private System.Windows.Forms.DataGridView dgvPlanReference;
    }
}