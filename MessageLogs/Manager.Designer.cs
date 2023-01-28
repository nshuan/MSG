namespace MessageLogs
{
    partial class Manager
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
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.gbLoginBox = new System.Windows.Forms.GroupBox();
            this.gbOnlineUsers = new System.Windows.Forms.GroupBox();
            this.dgvOnlineUsers = new System.Windows.Forms.DataGridView();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbWaitingRoom = new System.Windows.Forms.GroupBox();
            this.dgvWaitingUsers = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbMaxOnlineUser = new System.Windows.Forms.Label();
            this.lbMaxWaitingUser = new System.Windows.Forms.Label();
            this.gbLoginBox.SuspendLayout();
            this.gbOnlineUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOnlineUsers)).BeginInit();
            this.gbWaitingRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWaitingUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // tbUserName
            // 
            this.tbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserName.Location = new System.Drawing.Point(22, 33);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(351, 38);
            this.tbUserName.TabIndex = 2;
            this.tbUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbUserName_KeyDown);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(22, 96);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(351, 28);
            this.btnAddUser.TabIndex = 0;
            this.btnAddUser.Text = "Add user";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // gbLoginBox
            // 
            this.gbLoginBox.Controls.Add(this.lbMaxWaitingUser);
            this.gbLoginBox.Controls.Add(this.lbMaxOnlineUser);
            this.gbLoginBox.Controls.Add(this.btnAddUser);
            this.gbLoginBox.Controls.Add(this.tbUserName);
            this.gbLoginBox.Location = new System.Drawing.Point(13, 13);
            this.gbLoginBox.Name = "gbLoginBox";
            this.gbLoginBox.Size = new System.Drawing.Size(775, 148);
            this.gbLoginBox.TabIndex = 3;
            this.gbLoginBox.TabStop = false;
            this.gbLoginBox.Text = "Login";
            // 
            // gbOnlineUsers
            // 
            this.gbOnlineUsers.Controls.Add(this.dgvOnlineUsers);
            this.gbOnlineUsers.Location = new System.Drawing.Point(13, 168);
            this.gbOnlineUsers.Name = "gbOnlineUsers";
            this.gbOnlineUsers.Size = new System.Drawing.Size(393, 270);
            this.gbOnlineUsers.TabIndex = 4;
            this.gbOnlineUsers.TabStop = false;
            this.gbOnlineUsers.Text = "Online";
            // 
            // dgvOnlineUsers
            // 
            this.dgvOnlineUsers.AllowUserToAddRows = false;
            this.dgvOnlineUsers.AllowUserToDeleteRows = false;
            this.dgvOnlineUsers.AllowUserToOrderColumns = true;
            this.dgvOnlineUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOnlineUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Username,
            this.Id});
            this.dgvOnlineUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOnlineUsers.Location = new System.Drawing.Point(3, 18);
            this.dgvOnlineUsers.Name = "dgvOnlineUsers";
            this.dgvOnlineUsers.ReadOnly = true;
            this.dgvOnlineUsers.RowHeadersWidth = 51;
            this.dgvOnlineUsers.RowTemplate.Height = 24;
            this.dgvOnlineUsers.Size = new System.Drawing.Size(387, 249);
            this.dgvOnlineUsers.TabIndex = 0;
            // 
            // Username
            // 
            this.Username.HeaderText = "Username";
            this.Username.MinimumWidth = 6;
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            this.Username.Width = 125;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 125;
            // 
            // gbWaitingRoom
            // 
            this.gbWaitingRoom.Controls.Add(this.dgvWaitingUsers);
            this.gbWaitingRoom.Location = new System.Drawing.Point(412, 168);
            this.gbWaitingRoom.Name = "gbWaitingRoom";
            this.gbWaitingRoom.Size = new System.Drawing.Size(376, 267);
            this.gbWaitingRoom.TabIndex = 5;
            this.gbWaitingRoom.TabStop = false;
            this.gbWaitingRoom.Text = "Waiting Room";
            // 
            // dgvWaitingUsers
            // 
            this.dgvWaitingUsers.AllowUserToAddRows = false;
            this.dgvWaitingUsers.AllowUserToDeleteRows = false;
            this.dgvWaitingUsers.AllowUserToOrderColumns = true;
            this.dgvWaitingUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWaitingUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvWaitingUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWaitingUsers.Location = new System.Drawing.Point(3, 18);
            this.dgvWaitingUsers.Name = "dgvWaitingUsers";
            this.dgvWaitingUsers.ReadOnly = true;
            this.dgvWaitingUsers.RowHeadersWidth = 51;
            this.dgvWaitingUsers.RowTemplate.Height = 24;
            this.dgvWaitingUsers.Size = new System.Drawing.Size(370, 246);
            this.dgvWaitingUsers.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Username";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Id";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // lbMaxOnlineUser
            // 
            this.lbMaxOnlineUser.AutoSize = true;
            this.lbMaxOnlineUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaxOnlineUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbMaxOnlineUser.Location = new System.Drawing.Point(469, 51);
            this.lbMaxOnlineUser.Name = "lbMaxOnlineUser";
            this.lbMaxOnlineUser.Size = new System.Drawing.Size(53, 20);
            this.lbMaxOnlineUser.TabIndex = 3;
            this.lbMaxOnlineUser.Text = "label1";
            // 
            // lbMaxWaitingUser
            // 
            this.lbMaxWaitingUser.AutoSize = true;
            this.lbMaxWaitingUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaxWaitingUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbMaxWaitingUser.Location = new System.Drawing.Point(469, 87);
            this.lbMaxWaitingUser.Name = "lbMaxWaitingUser";
            this.lbMaxWaitingUser.Size = new System.Drawing.Size(53, 20);
            this.lbMaxWaitingUser.TabIndex = 4;
            this.lbMaxWaitingUser.Text = "label1";
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbWaitingRoom);
            this.Controls.Add(this.gbOnlineUsers);
            this.Controls.Add(this.gbLoginBox);
            this.Name = "Manager";
            this.Text = "Manager";
            this.gbLoginBox.ResumeLayout(false);
            this.gbLoginBox.PerformLayout();
            this.gbOnlineUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOnlineUsers)).EndInit();
            this.gbWaitingRoom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWaitingUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.GroupBox gbLoginBox;
        private System.Windows.Forms.GroupBox gbOnlineUsers;
        private System.Windows.Forms.DataGridView dgvOnlineUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.GroupBox gbWaitingRoom;
        private System.Windows.Forms.DataGridView dgvWaitingUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label lbMaxWaitingUser;
        private System.Windows.Forms.Label lbMaxOnlineUser;
    }
}