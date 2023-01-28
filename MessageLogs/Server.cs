using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MessageLogs
{
    public class Server
    {
        public List<string> userIDs = new List<string>();
        public List<Client> userClients = new List<Client>();

        public MessageBuffer msgBuffer;

        private Client system;

        public int maxUser;
        public int maxWaiter;
        private int maxMsg;

        public Server()
        {
            maxUser = 4;
            maxWaiter = 4;
            maxMsg = 20;

            userIDs = new List<string>();
            userClients = new List<Client>();

            system = new ClientBuilder()
                .UserName("System notification")
                .Id("SystemNotification")
                .UserColor(Color.Red);

            msgBuffer = new MessageBuffer(maxMsg);
        }

        public void UpdateLogs(Client sender, string m)
        {
            string time = DateTime.Now.ToString();
            msgBuffer.Add(sender, m, time);

            foreach (Client client in userClients)
            {
                client.UpdateLogs(msgBuffer);
            }
        }

        public void AddUser(string name)
        {
            if (userIDs.Count < maxUser + maxWaiter)
            {
                string newID = "User000" + (userIDs.Count + 1).ToString();

                Client newUser = new ClientBuilder()
                    .UserName(name)
                    .Id(newID)
                    .UserColor(Color.Green);

                userIDs.Add(newID);
                userClients.Add(newUser);

                newUser.Text = name;

                if (userIDs.Count <= maxUser)
                {
                    UpdateLogs(system, name + " hopped into the chat!");
                    newUser.Show();
                }    
                else
                {
                    MessageBox.Show("You are added to the waiting room!\nPlease wait till someone left the conversation.", "Hold up", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("The room is full!\nPlease join later!", "Loser", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }    
        }

        public void RemoveUser(string id)
        {
            int foundAt = userIDs.IndexOf(id);
            if (foundAt != -1)
            {
                string name = userClients[foundAt].userName;

                userIDs.RemoveAt(foundAt);
                userClients.RemoveAt(foundAt);

                UpdateLogs(system, name + " left the conversation!");
            }
        }

    }

    public class MessageBuffer
    {
        private int size;
        public MessageInfo[] messages;
        public int head = 0;
        public int tail = 0;

        public MessageBuffer(int _size)
        {
            size = _size;
            messages = new MessageInfo[size];
        }

        public void Add(Client sender, string message, string time)
        {
            MessageInfo m = new MessageInfo(sender, message, time);
            messages[tail] = m;
            tail = (tail + 1) % size;

            if (tail == head)
            {
                head = (head + 1) % size;
            }
        }

        public MessageInfo Read()
        {
            if (head == tail)
                return null;
            else
            {
                var result = messages[head];
                head = (head + 1) % size;
                return result;
            }
        }
    }

    public class MessageInfo
    {
        public Client sender;
        public string message;
        public string time;

        public MessageInfo(Client s, string m, string t)
        {
            sender = s;
            message = m;
            time = t;
        }    
    }
}
