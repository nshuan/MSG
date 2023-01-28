using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageLogs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbMessageInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbMessageInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                rtbMessageOutput.Text += "\n" + tbMessageInput.Text;
                tbMessageInput.Text = "";
                tbMessageInput.Focus();
            }
        }
    }
}
