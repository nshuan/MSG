using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MessageLogs
{
    public partial class Manager : Form
    {
        private Server server;

        public Manager()
        {
            InitializeComponent();

            server = new Server();

            UpdateMaxUser();
        }

        void UserDataUpdate()
        {
            dgvOnlineUsers.Rows.Clear();
            dgvWaitingUsers.Rows.Clear();

            int counter = 0;

            foreach (Client user in server.userClients)
            {
                string[] row = new string[] { user.userName, user.id};

                if (counter < server.maxUser)
                {
                    dgvOnlineUsers.Rows.Add(row);
                }    
                else
                {
                    dgvWaitingUsers.Rows.Add(row);
                }

                counter += 1;
            }    
        }

        void UpdateMaxUser()
        {
            lbMaxOnlineUser.Text = "Max user: " + server.maxUser;
            lbMaxWaitingUser.Text = "Max waiting slots: " + server.maxWaiter;
        }

        public void UserLeft(string id)
        {
            int i = server.userIDs.IndexOf(id);
            string name = server.userClients[i].userName;

            server.RemoveUser(id);

            if (dgvWaitingUsers.Rows.Count > 1)
            {
                server.userClients[server.maxUser - 1].Show();
            }

            UserDataUpdate();
        }

        public void UserLogin()
        {
            string name = tbUserName.Text;

            if (name != String.Empty)
            {
                server.AddUser(name);

                UserDataUpdate();
            }

            tbUserName.Text = "";
        }

        public void SendMessage(Client sender, string m)
        {
            server.UpdateLogs(sender, m);
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            UserLogin();
        }

        private void tbUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                UserLogin();
            }    
        }
    }
}
