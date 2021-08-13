using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
namespace Server
{
    public partial class MainForm : Form
    {
        public bool IsBegin { get; set; }
        public MainForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            IsBegin = false;
        }
        void Watch(object o)
        {
            Socket watchSocket = o as Socket;
            while (IsBegin)
            {
                Socket sendSocket = watchSocket.Accept();
                ShowLog($"收到连接：{sendSocket.RemoteEndPoint}。");
                Thread thread = new(Receive);
                thread.IsBackground = true;
                thread.Start(sendSocket);
            }
        }
        private void Receive(object o)
        {
            Socket sendSocket = o as Socket;
            int size;
            do
            {
                try
                {
                    byte[] buffer = new byte[1024 * 1024];
                    size = sendSocket.Receive(buffer);
                    ShowLog(sendSocket.RemoteEndPoint + "：" + (size == 0 ? "断开连接。" : Encoding.Default.GetString(buffer, 0, size)));
                }
                catch
                {
                    size = 0;
                }
            } while (size != 0);
        }
        private void ShowLog(string log)
        {
            logEditor.AppendText(log + Environment.NewLine);
        }
        private void BeginWatch(object sender, EventArgs e)
        {
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
            if (!IsBegin)
            {
                try
                {
                    Socket watchSocket = new(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    watchSocket.Bind(port);
                    IsBegin = true;
                    watchSocket.Listen(10);
                    Thread thread = new(Watch);
                    thread.IsBackground = true;
                    thread.Start(watchSocket);
                    beginButton.Text = "停止监听";
                    ShowLog($"开始监听：{port}。");
                }
                catch (Exception error)
                {
                    ShowLog($"出现异常：{error}。");
                }
            }
            else
            {
                IsBegin = false;
                beginButton.Text = "开始监听";
                ShowLog($"停止监听：{port}。");
            }
        }
    }
}