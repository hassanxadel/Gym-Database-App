namespace GymMembershipSystem.Forms
{
    partial class ReportsForm
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
            this.dgvReports = new System.Windows.Forms.DataGridView();
            this.btnMemberHistory = new System.Windows.Forms.Button();
            this.btnRevenueReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReports
            // 
            this.dgvReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReports.Location = new System.Drawing.Point(12, 12);
            this.dgvReports.Name = "dgvReports";
            this.dgvReports.RowHeadersWidth = 51;
            this.dgvReports.RowTemplate.Height = 24;
            this.dgvReports.Size = new System.Drawing.Size(776, 363);
            this.dgvReports.TabIndex = 0;
            // 
            // btnMemberHistory
            // 
            this.btnMemberHistory.Location = new System.Drawing.Point(90, 393);
            this.btnMemberHistory.Name = "btnMemberHistory";
            this.btnMemberHistory.Size = new System.Drawing.Size(270, 45);
            this.btnMemberHistory.TabIndex = 1;
            this.btnMemberHistory.Text = "View Reports";
            this.btnMemberHistory.UseVisualStyleBackColor = true;
            this.btnMemberHistory.Click += new System.EventHandler(this.btnMemberHistory_Click);
            // 
            // btnRevenueReport
            // 
            this.btnRevenueReport.Location = new System.Drawing.Point(433, 393);
            this.btnRevenueReport.Name = "btnRevenueReport";
            this.btnRevenueReport.Size = new System.Drawing.Size(270, 45);
            this.btnRevenueReport.TabIndex = 2;
            this.btnRevenueReport.Text = "Revenue Reports";
            this.btnRevenueReport.UseVisualStyleBackColor = true;
            this.btnRevenueReport.Click += new System.EventHandler(this.btnRevenueReport_Click);
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRevenueReport);
            this.Controls.Add(this.btnMemberHistory);
            this.Controls.Add(this.dgvReports);
            this.Name = "ReportsForm";
            this.Text = "ReportsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReports;
        private System.Windows.Forms.Button btnMemberHistory;
        private System.Windows.Forms.Button btnRevenueReport;
    }
}