using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
namespace Client
{
    public partial class MainForm : Form
    {
        private Socket sendSocket_;
        public MainForm()
        {
            InitializeComponent();
        }
        private void ShowLog(string log)
        {
            logEditor.AppendText(log + Environment.NewLine);
        }
        private void Connect(object sender, EventArgs e)
        {
            sendSocket_ = new(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint port;
            try
            {
                IPAddress ip = IPAddress.Parse(IPEditor.Text);
                port = new(ip, int.Parse(portEditor.Text));
            }
            catch
            {
                MessageBox.Show("输入有误，请重新输入。", "错误");
                IPEditor.Clear();
                portEditor.Clear();
                return;
            }
            try
            {
                sendSocket_.Connect(port);
                ShowLog($"连接成功：{port}。");
            }
            catch (Exception error)
            {
                ShowLog($"出现异常：{error}。");
            }
        }
        private void SendMessage(object sender, EventArgs e)
        {
            byte[] buffer = Encoding.Default.GetBytes(messageEditor.Text);
            sendSocket_.Send(buffer);
        }
    }
}