namespace MessageLogs
{
    partial class Form1
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
            this.rtbMessageOutput = new System.Windows.Forms.RichTextBox();
            this.tbMessageInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rtbMessageOutput
            // 
            this.rtbMessageOutput.Location = new System.Drawing.Point(27, 13);
            this.rtbMessageOutput.Name = "rtbMessageOutput";
            this.rtbMessageOutput.Size = new System.Drawing.Size(384, 333);
            this.rtbMessageOutput.TabIndex = 0;
            this.rtbMessageOutput.Text = "";
            // 
            // tbMessageInput
            // 
            this.tbMessageInput.Location = new System.Drawing.Point(27, 376);
            this.tbMessageInput.Name = "tbMessageInput";
            this.tbMessageInput.Size = new System.Drawing.Size(383, 22);
            this.tbMessageInput.TabIndex = 1;
            this.tbMessageInput.TextChanged += new System.EventHandler(this.tbMessageInput_TextChanged);
            this.tbMessageInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbMessageInput_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbMessageInput);
            this.Controls.Add(this.rtbMessageOutput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbMessageOutput;
        private System.Windows.Forms.TextBox tbMessageInput;
    }
}

