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
    public partial class Client : Form
    {
        public string userName;
        public string id;
        public Color color;

        Manager mng;

        public Client()
        {
            InitializeComponent();
            mng = Application.OpenForms["Manager"] as Manager;
        }

        public void UpdateLogs(MessageBuffer msgBuffer)
        {
            int originalHead = msgBuffer.head;
            string lastSenderId = "";

            rtbMessageLogs.Text = "";

            MessageInfo msg = msgBuffer.Read();
            while (msg != null)
            {
                if (msg.sender.id != lastSenderId)
                {
                    if (msg.sender.id == this.id)
                    {
                        rtbMessageLogs.SelectionColor = Color.Blue;
                        rtbMessageLogs.SelectionAlignment = HorizontalAlignment.Right;
                    }
                    else
                    {
                        rtbMessageLogs.SelectionAlignment = HorizontalAlignment.Left;
                        rtbMessageLogs.SelectionColor = msg.sender.color;
                    }
                    rtbMessageLogs.AppendText("\n" + msg.sender.userName + "\n");
                }

                if (msg.sender.id == this.id)
                    rtbMessageLogs.SelectionAlignment = HorizontalAlignment.Right;
                rtbMessageLogs.AppendText(msg.message + "\n");

                if (msg.sender.id == this.id)
                    rtbMessageLogs.SelectionAlignment = HorizontalAlignment.Right;
                rtbMessageLogs.SelectionFont = new Font(rtbMessageLogs.Font.FontFamily, 7f, FontStyle.Italic);
                rtbMessageLogs.SelectionColor = Color.Gray;
                rtbMessageLogs.AppendText(msg.time + "\n");

                lastSenderId = msg.sender.id;
                msg = msgBuffer.Read();
            }    

            msgBuffer.head = originalHead;

            rtbMessageLogs.SelectionStart = rtbMessageLogs.Text.Length;
            rtbMessageLogs.ScrollToCaret();
        }

        private void SendMessage()
        {
            bool isEmpty = true;
            string message = tbMessageInputBox.Text;

            for (int i = 0; i < message.Length; i++)
            {
                char c = message[i];
                if (c != ' ' && c != '\n')
                {
                    isEmpty = false;
                    break;
                }    
            }    

            if (!isEmpty)
            {
                mng.SendMessage(this, message);
            }    
        }   
        
        private void Client_FormClosed(object sender, FormClosingEventArgs e)
        {
            if (mng != null)
                mng.UserLeft(id);
        }

        private void btn_SendMessage_Click(object sender, EventArgs e)
        {
            SendMessage();
        }

        private void tbMessageInputBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendMessage();
                tbMessageInputBox.Clear();
            }

        }
    }

    public class ClientBuilder
    {
        protected Client user = new Client();

        public ClientBuilder Id(string value)
        {
            user.id = value;
            return this;
        }

        public ClientBuilder UserName(string value)
        {
            user.userName = value;
            return this;
        }

        public ClientBuilder UserColor(Color value)
        {
            user.color = value;
            return this;
        }    

        public static implicit operator Client(ClientBuilder cb)
        {
            return cb.user;
        }
    }
}
