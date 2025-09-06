using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace message
{
    public partial class Dialog: Form
    {
        string _name;
        TcpClient client;
        NetworkStream stream;
        public Dialog(string UserName)
        {
            InitializeComponent();
            _name = UserName;
            TB_Dialog.Text += $"\r\nПользователь {_name} присоеденился!";
            ConnectToServer();
        }

        private void ConnectToServer()
        {
            try
            {
                client = new TcpClient("127.0.0.1", 8888);
                stream = client.GetStream();

                Thread receiveThread = new Thread(ReceiveMessage);
                receiveThread.IsBackground = true;
                receiveThread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка подключения к серверу:\n" + ex.Message);
            }
        }

        private void ReceiveMessage()
        {
            byte[] buffer = new byte[1024];
            while (true)
            {
                int bytes = stream.Read(buffer, 0, buffer.Length);
                string message = Encoding.UTF8.GetString(buffer, 0, buffer.Length);
                Invoke((MethodInvoker)(() => TB_Dialog.AppendText(message + Environment.NewLine)));
            }
        }

        private void BT_Send_Click(object sender, EventArgs e)
        {
            string message = $"\r\n{_name}: {TB_Message.Text}";
            byte[] data = Encoding.UTF8.GetBytes(message);
            stream.Write(data, 0, data.Length);
            TB_Dialog.Text += message;
            TB_Message.Clear();
        }
    }
}
