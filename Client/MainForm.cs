using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
namespace Client
{
    public partial class MainForm : Form
    {
        private Socket sendSocket_;
        public MainForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        private void Receive()
        {
            int size;
            do
            {
                try
                {
                    byte[] buffer = new byte[1024 * 1024];
                    size = sendSocket_.Receive(buffer);
                    switch (buffer[0])
                    {
                        case 0:
                            ShowLog(sendSocket_.RemoteEndPoint + "：" + (size == 0 ? "断开连接。" : Encoding.Default.GetString(buffer, 1, size - 1)));
                            break;
                        case 1:
                            SaveFileDialog dialog = new();
                            dialog.Title = "保存文件";
                            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                            dialog.Filter = "所有类型|*.*";
                            dialog.ShowDialog(this);
                            using (FileStream file = new(dialog.FileName, FileMode.Create, FileAccess.Write))
                            {
                                file.Write(buffer, 1, size - 1);
                            }
                            MessageBox.Show("保存成功。", "成功");
                            break;
                        case 2:
                            Point current = Location;
                            for (int i = 0; i < 10; i++)
                            {
                                Location = i % 2 == 0 ? new Point(current.X - 10, current.Y - 10) : current;
                                Thread.Sleep(50);
                            }
                            break;
                        default:
                            break;
                    }
                }
                catch
                {
                    size = 1;
                }
            } while (size != 1);
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
                Thread thread = new(Receive);
                thread.IsBackground = true;
                thread.Start();
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
            ShowLog(sendSocket_.LocalEndPoint + "：" + messageEditor.Text);
            messageEditor.Clear();
        }
    }
}