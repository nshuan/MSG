namespace MessageLogs
{
    partial class Client
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
            this.tbMessageInputBox = new System.Windows.Forms.TextBox();
            this.btn_SendMessage = new System.Windows.Forms.Button();
            this.rtbMessageLogs = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // tbMessageInputBox
            // 
            this.tbMessageInputBox.AcceptsReturn = true;
            this.tbMessageInputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMessageInputBox.Location = new System.Drawing.Point(15, 497);
            this.tbMessageInputBox.Name = "tbMessageInputBox";
            this.tbMessageInputBox.Size = new System.Drawing.Size(406, 26);
            this.tbMessageInputBox.TabIndex = 1;
            this.tbMessageInputBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbMessageInputBox_KeyDown);
            // 
            // btn_SendMessage
            // 
            this.btn_SendMessage.Location = new System.Drawing.Point(427, 495);
            this.btn_SendMessage.Name = "btn_SendMessage";
            this.btn_SendMessage.Size = new System.Drawing.Size(55, 33);
            this.btn_SendMessage.TabIndex = 2;
            this.btn_SendMessage.Text = "Send";
            this.btn_SendMessage.UseVisualStyleBackColor = true;
            this.btn_SendMessage.Click += new System.EventHandler(this.btn_SendMessage_Click);
            // 
            // rtbMessageLogs
            // 
            this.rtbMessageLogs.Location = new System.Drawing.Point(15, 23);
            this.rtbMessageLogs.Name = "rtbMessageLogs";
            this.rtbMessageLogs.Size = new System.Drawing.Size(467, 459);
            this.rtbMessageLogs.TabIndex = 3;
            this.rtbMessageLogs.Text = "";
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 540);
            this.Controls.Add(this.rtbMessageLogs);
            this.Controls.Add(this.btn_SendMessage);
            this.Controls.Add(this.tbMessageInputBox);
            this.Name = "Client";
            this.Text = "Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Client_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbMessageInputBox;
        private System.Windows.Forms.Button btn_SendMessage;
        private System.Windows.Forms.RichTextBox rtbMessageLogs;
    }
}