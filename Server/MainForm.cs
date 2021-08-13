using System;
using System.Collections.Generic;
using System.IO;
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
#pragma warning disable IDE0044
        private List<Socket> sendSockets_;
#pragma warning restore IDE0044
        public MainForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            IsBegin = false;
            sendSockets_ = new();
        }
        void Watch(object o)
        {
            Socket watchSocket = o as Socket;
            while (IsBegin)
            {
                sendSockets_.Add(watchSocket.Accept());
                IPCombo.Items.Add(sendSockets_[^1].RemoteEndPoint.ToString());
                if (IPCombo.SelectedIndex == -1)
                {
                    IPCombo.SelectedIndex = 0;
                }
                ShowLog($"收到连接：{sendSockets_[^1].RemoteEndPoint}。");
                Thread thread = new(Receive);
                thread.IsBackground = true;
                thread.Start(sendSockets_.Count - 1);
            }
        }
        private void Receive(object o)
        {
            int index = (int)o;
            int size;
            do
            {
                try
                {
                    byte[] buffer = new byte[1024 * 1024];
                    size = sendSockets_[index].Receive(buffer);
                    ShowLog(sendSockets_[index].RemoteEndPoint + "：" + (size == 0 ? "断开连接。" : Encoding.Default.GetString(buffer, 0, size)));
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
        private void SendMessage(object sender, EventArgs e)
        {
            byte[] buffer = Encoding.Default.GetBytes(messageEditor.Text);
            List<byte> list = new();
            list.Add(0);
            list.AddRange(buffer);
            sendSockets_[IPCombo.SelectedIndex].Send(list.ToArray());
            ShowLog(sendSockets_[IPCombo.SelectedIndex].LocalEndPoint + "：" + messageEditor.Text);
            messageEditor.Clear();
        }
        private void SelectFile(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new();
            dialog.Title = "打开文件";
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            dialog.Filter = "所有类型|*.*";
            dialog.ShowDialog();
            directoryEditor.Text = dialog.FileName;
        }

        private void SendFile(object sender, EventArgs e)
        {
            using FileStream file = new(directoryEditor.Text, FileMode.Open, FileAccess.Read);
            byte[] buffer = new byte[1024 * 1024 * 10];
            int size = file.Read(buffer);
            List<byte> list = new();
            list.Add(1);
            list.AddRange(buffer);
            sendSockets_[IPCombo.SelectedIndex].Send(list.ToArray(), 0, size + 1, SocketFlags.None);
            ShowLog(sendSockets_[IPCombo.SelectedIndex].LocalEndPoint + "：发送文件“" + directoryEditor.Text + "”。");
        }

        private void SendVibrate(object sender, EventArgs e)
        {
            byte[] buffer = new byte[2];
            buffer[0] = 2;
            sendSockets_[IPCombo.SelectedIndex].Send(buffer);
            ShowLog(sendSockets_[IPCombo.SelectedIndex].LocalEndPoint + "：发送震动。");
        }
    }
}