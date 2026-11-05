namespace GymMembershipSystem.Forms
{
    partial class RoomForm
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
            this.nudCapacity = new System.Windows.Forms.NumericUpDown();
            this.btnUpdateRoom = new System.Windows.Forms.Button();
            this.btnDeleteRoom = new System.Windows.Forms.Button();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.txtActivity = new System.Windows.Forms.TextBox();
            this.txtRoomName = new System.Windows.Forms.TextBox();
            this.Last_Name = new System.Windows.Forms.Label();
            this.First_Name = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoadRooms = new System.Windows.Forms.Button();
            this.dgvRooms = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // nudCapacity
            // 
            this.nudCapacity.Location = new System.Drawing.Point(127, 317);
            this.nudCapacity.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudCapacity.Name = "nudCapacity";
            this.nudCapacity.Size = new System.Drawing.Size(120, 22);
            this.nudCapacity.TabIndex = 51;
            // 
            // btnUpdateRoom
            // 
            this.btnUpdateRoom.Location = new System.Drawing.Point(419, 367);
            this.btnUpdateRoom.Name = "btnUpdateRoom";
            this.btnUpdateRoom.Size = new System.Drawing.Size(182, 71);
            this.btnUpdateRoom.TabIndex = 50;
            this.btnUpdateRoom.Text = "Update Room";
            this.btnUpdateRoom.UseVisualStyleBackColor = true;
            this.btnUpdateRoom.Click += new System.EventHandler(this.btnUpdateRoom_Click);
            // 
            // btnDeleteRoom
            // 
            this.btnDeleteRoom.Location = new System.Drawing.Point(215, 367);
            this.btnDeleteRoom.Name = "btnDeleteRoom";
            this.btnDeleteRoom.Size = new System.Drawing.Size(182, 71);
            this.btnDeleteRoom.TabIndex = 49;
            this.btnDeleteRoom.Text = "Delete Room";
            this.btnDeleteRoom.UseVisualStyleBackColor = true;
            this.btnDeleteRoom.Click += new System.EventHandler(this.btnDeleteRoom_Click);
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Location = new System.Drawing.Point(12, 367);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(182, 71);
            this.btnAddRoom.TabIndex = 48;
            this.btnAddRoom.Text = "Add Room";
            this.btnAddRoom.UseVisualStyleBackColor = true;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // txtActivity
            // 
            this.txtActivity.Location = new System.Drawing.Point(127, 278);
            this.txtActivity.Name = "txtActivity";
            this.txtActivity.Size = new System.Drawing.Size(120, 22);
            this.txtActivity.TabIndex = 47;
            // 
            // txtRoomName
            // 
            this.txtRoomName.Location = new System.Drawing.Point(127, 241);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.Size = new System.Drawing.Size(120, 22);
            this.txtRoomName.TabIndex = 46;
            // 
            // Last_Name
            // 
            this.Last_Name.AutoSize = true;
            this.Last_Name.Location = new System.Drawing.Point(15, 284);
            this.Last_Name.Name = "Last_Name";
            this.Last_Name.Size = new System.Drawing.Size(49, 16);
            this.Last_Name.TabIndex = 45;
            this.Last_Name.Text = "Activity";
            // 
            // First_Name
            // 
            this.First_Name.AutoSize = true;
            this.First_Name.Location = new System.Drawing.Point(15, 247);
            this.First_Name.Name = "First_Name";
            this.First_Name.Size = new System.Drawing.Size(84, 16);
            this.First_Name.TabIndex = 44;
            this.First_Name.Text = "Room Name";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(15, 323);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(60, 16);
            this.Email.TabIndex = 43;
            this.Email.Text = "Capacity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 41;
            // 
            // btnLoadRooms
            // 
            this.btnLoadRooms.AccessibleName = "";
            this.btnLoadRooms.Location = new System.Drawing.Point(619, 367);
            this.btnLoadRooms.Name = "btnLoadRooms";
            this.btnLoadRooms.Size = new System.Drawing.Size(169, 71);
            this.btnLoadRooms.TabIndex = 40;
            this.btnLoadRooms.Text = "Load Room";
            this.btnLoadRooms.UseVisualStyleBackColor = true;
            this.btnLoadRooms.Click += new System.EventHandler(this.btnLoadRooms_Click);
            // 
            // dgvRooms
            // 
            this.dgvRooms.AccessibleName = "dgvData";
            this.dgvRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRooms.Location = new System.Drawing.Point(12, 12);
            this.dgvRooms.Name = "dgvRooms";
            this.dgvRooms.RowHeadersWidth = 51;
            this.dgvRooms.RowTemplate.Height = 24;
            this.dgvRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRooms.Size = new System.Drawing.Size(776, 209);
            this.dgvRooms.TabIndex = 39;
            this.dgvRooms.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRooms_CellClick);
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nudCapacity);
            this.Controls.Add(this.btnUpdateRoom);
            this.Controls.Add(this.btnDeleteRoom);
            this.Controls.Add(this.btnAddRoom);
            this.Controls.Add(this.txtActivity);
            this.Controls.Add(this.txtRoomName);
            this.Controls.Add(this.Last_Name);
            this.Controls.Add(this.First_Name);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLoadRooms);
            this.Controls.Add(this.dgvRooms);
            this.Name = "RoomForm";
            this.Text = "Manage Rooms";
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudCapacity;
        private System.Windows.Forms.Button btnUpdateRoom;
        private System.Windows.Forms.Button btnDeleteRoom;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.TextBox txtActivity;
        private System.Windows.Forms.TextBox txtRoomName;
        private System.Windows.Forms.Label Last_Name;
        private System.Windows.Forms.Label First_Name;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoadRooms;
        private System.Windows.Forms.DataGridView dgvRooms;
    }
}