using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Trafic_Lamp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pinkOn_CheckedChanged(object sender, EventArgs e)
        {
            if (txtIPClient.Text.Equals(""))
            {
                MessageBox.Show("IP Tujuan belum di setting");
                purpleOn.Checked = false;
            }
            else
            {
                varGlobal.alamatIPServer = txtIPClient.Text;
                varGlobal.port = Int16.Parse(txtPortClient.Text);
                SocketTCP.StartClient("Pink On,0");
            }
        }

        private void pinkOff_CheckedChanged(object sender, EventArgs e)
        {
            if (txtIPClient.Text.Equals(""))
            {
                MessageBox.Show("IP Tujuan belum di setting");
                purpleOn.Checked = false;
            }
            else
            {
                varGlobal.alamatIPServer = txtIPClient.Text;
                varGlobal.port = Int16.Parse(txtPortClient.Text);
                SocketTCP.StartClient("Pink Off,0");
            }
        }

        private void orangeOn_CheckedChanged(object sender, EventArgs e)
        {
            if (txtIPClient.Text.Equals(""))
            {
                MessageBox.Show("IP Tujuan belum di set");
                purpleOn.Checked = false;
            }
            else
            {
                varGlobal.alamatIPServer = txtIPClient.Text;
                varGlobal.port = Int16.Parse(txtPortClient.Text);
                SocketTCP.StartClient("Yellow On,1");
            }
        }

        private void orangeOff_CheckedChanged(object sender, EventArgs e)
        {
            if (txtIPClient.Text.Equals(""))
            {
                MessageBox.Show("IP Tujuan belum di set");
                purpleOn.Checked = false;
            }
            else
            {
                varGlobal.alamatIPServer = txtIPClient.Text;
                varGlobal.port = Int16.Parse(txtPortClient.Text);
                SocketTCP.StartClient("Yellow Off,1");
            }
        }

        private void yellowOn_CheckedChanged(object sender, EventArgs e)
        {
            if (txtIPClient.Text.Equals(""))
            {
                MessageBox.Show("IP Tujuan belum di set");
                purpleOn.Checked = false;
            }
            else
            {
                varGlobal.alamatIPServer = txtIPClient.Text;
                varGlobal.port = Int16.Parse(txtPortClient.Text);
                SocketTCP.StartClient("Orange On,2");
            }
        }

        private void yellowOff_CheckedChanged(object sender, EventArgs e)
        {
            if (txtIPClient.Text.Equals(""))
            {
                MessageBox.Show("IP Tujuan belum di set");
                purpleOn.Checked = false;
            }
            else
            {
                varGlobal.alamatIPServer = txtIPClient.Text;
                varGlobal.port = Int16.Parse(txtPortClient.Text);
                SocketTCP.StartClient("Orange Off,2");
            }
        }

        // SERVER

        private void listenSocket()
        {
            varGlobal.port = Int16.Parse(txtPortServer.Text);
            varGlobal.alamatIPServer = txtIPServer.Text;
            SocketTCP.StartListening();
        }

        private void timerServer_Tick(object sender, EventArgs e)
        {

            txtCommand.Clear();
            varGlobal.command = varGlobal.terimapesandiserver.Split(',');
            txtCommand.Text = "Lampu " + varGlobal.command[0];
            lampChanger(varGlobal.command[0], Int16.Parse(varGlobal.command[1]));
            lamps();
        }

        private void lamps()
        {
            String[] pink = varGlobal.bulb[0].Split(' ');
            String[] yellow = varGlobal.bulb[1].Split(' ');
            String[] orange = varGlobal.bulb[2].Split(' ');

            if (pink[1].Equals("On")) {
                pinkPanel.BackColor = Color.Pink;
            } else
                pinkPanel.BackColor = Color.White;

            if (yellow[1].Equals("On"))
                yellowPanel.BackColor = Color.Yellow;
            else
                yellowPanel.BackColor = Color.White;

            if (orange[1].Equals("On"))
                orangePanel.BackColor = Color.Orange;
            else
                orangePanel.BackColor = Color.White;
        }

        private void lampChanger(string command, int pos)
        {
            varGlobal.bulb[pos] = command;
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            Thread thr = new Thread(listenSocket);
            if (txtIPServer.Text != "")
            {
                thr.Start();
                btnListen.Enabled = false;
            }
            else
            {
                MessageBox.Show("Isi alamat IP");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtCommand_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCommand_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
