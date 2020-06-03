using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using SimpleTCP;

namespace Client_Server_NTH
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
        }
        SimpleTcpServer Server1;
        
        private void Server_Load(object sender, EventArgs e)
        {
            Server1 = new SimpleTcpServer();
            Server1.Delimiter = 0x13;//enter
            Server1.StringEncoder = Encoding.UTF8;
            Server1.DataReceived += Server1_DataReceived;
        }

        private void Server1_DataReceived(object sender, SimpleTCP.Message e)
        {
            txtDisplay.Invoke((MethodInvoker)delegate ()
            {

                txtDisplay.Text += e.MessageString;
                if (e.MessageString.Contains("0"))
                    e.ReplyLine("You said: Zero \n");
                else if (e.MessageString.Contains("1"))
                    e.ReplyLine("You said: One \n");
                else if (e.MessageString.Contains("2"))
                    e.ReplyLine("You said: Two \n");
                else if (e.MessageString.Contains("3"))
                    e.ReplyLine("You said: Three \n");
                else if (e.MessageString.Contains("4"))
                    e.ReplyLine("You said: Four \n");
                else if (e.MessageString.Contains("5"))
                    e.ReplyLine("You said: Five \n");
                else if (e.MessageString.Contains("6"))
                    e.ReplyLine("You said: Six \n");
                else if (e.MessageString.Contains("7"))
                    e.ReplyLine("You said: Seven \n");
                else if (e.MessageString.Contains("8"))
                    e.ReplyLine("You said: Eight \n");
                else if (e.MessageString.Contains("9"))
                    e.ReplyLine("You said: Nine \n");
                else if (e.MessageString.Contains("End"))
                    e.ReplyLine("You said: Bye \n");
                else
                    e.ReplyLine("You said : Nhap lai");
            });
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            IPAddress ip;
            ip = IPAddress.Parse(txtHost.Text);
            Server1.Start(ip, Convert.ToInt32(txtPort.Text));
            txtDisplay.Text += "Server starting...";
        }

        private void btntop_Click(object sender, EventArgs e)
        {
            if (Server1.IsStarted)
                Server1.Stop();
        }
    }
}
