using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace AvukatMuvekkil
{
    public partial class MesajlasmaSayfasi : Form
    {
        Socket sck;
        EndPoint epLocal, epRemote;
        byte[] buffer;
        public string avip, muvip;
        public int muvport, avport;
        public MesajlasmaSayfasi()
        {
            InitializeComponent();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            avip = "";
            avport = 0;
            muvip = "";
            muvport = 0;
            this.Close();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                // converts from string to byte[]
                System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
                byte[] msg = new byte[1500];
                msg = enc.GetBytes(txtMessage.Text);
                // sending the message
                sck.Send(msg);
                // add to listbox
                listMessage.Items.Add("You: " + txtMessage.Text);
                // clear txtMessage
                txtMessage.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                //binding socket
                epLocal = new IPEndPoint(IPAddress.Parse(avip), Convert.ToInt32(avport));
                sck.Bind(epLocal);
                //connect to remote ip and port
                epRemote = new IPEndPoint(IPAddress.Parse(muvip), Convert.ToInt32(muvport));
                sck.Connect(epRemote);
                //start listening on a specific port
                buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
                btnSend.Enabled = true;
                btnStart.Text = "Bağlandı";
                btnStart.Enabled = false;
                txtMessage.Focus();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnKucult_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MesajlasmaSayfasi_Load(object sender, EventArgs e)
        {
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
        }
        public void MessageCallBack(IAsyncResult aResult)
        {
            try
            {
                int size = sck.EndReceiveFrom(aResult, ref epRemote);
                // check if theres actually information
                if (size > 0)
                {
                    // used to help us on getting the data
                    byte[] receivedData = new byte[1464];
                    // getting the message data
                    receivedData = (byte[])aResult.AsyncState;
                    // converts message data byte array to string
                    ASCIIEncoding eEncoding = new ASCIIEncoding();
                    string receivedMessage = eEncoding.GetString(receivedData);
                    // adding Message to the listbox
                    listMessage.Items.Add("Friend: " + receivedMessage);
                }
                // starts to listen the socket again
                buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }
    }
}
