using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Socket sck;
        EndPoint epLocal, epRemote;
        byte[] buffer;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            ServerIP.Text = GetLocalIP();
            ClientIP.Text = GetLocalIP();

        }

        private void Connect_Click(object sender, EventArgs e)
        {
            //Soket dinleme
            epLocal = new IPEndPoint(IPAddress.Parse(ServerIP.Text), Convert.ToInt32(ServerPort.Text));
            sck.Bind(epLocal);
            //Remote Ip bağlan
            epRemote = new IPEndPoint(IPAddress.Parse(ClientIP.Text), Convert.ToInt32(ClientPort.Text));
            sck.Connect(epRemote);
            //Port dinleme
            buffer = new byte[500];
            sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack),buffer);
        }

        private void MessageCallBack(IAsyncResult ar)
        {
            try
            {
                byte[] receivedData = new byte[1500];
                receivedData = (byte[])ar.AsyncState;
                //byte to string
                ASCIIEncoding aEncoding = new ASCIIEncoding();
                string receivedMessage = aEncoding.GetString(receivedData);
                //Message add listBox
                listMessage.Items.Add("Client : " + receivedMessage);
                buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Send_Click(object sender, EventArgs e)
        {
            //string message to byte
            ASCIIEncoding aEncoding = new ASCIIEncoding();
            byte[] sendingMessage = new byte[1500];
            sendingMessage = aEncoding.GetBytes(Message.Text);
            //sending encoding message
            sck.Send(sendingMessage);
            //add listbox
            listMessage.Items.Add("Server : " + Message.Text);
            Message.Text = "";
        }

        private string GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach(IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    return ip.ToString();
            }
            return "127.0.0.1";
        }
    }
}
