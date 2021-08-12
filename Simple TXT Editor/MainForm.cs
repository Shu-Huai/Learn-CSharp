using System.IO;
using System.Text;
using System.Windows.Forms;
namespace Simple_TXT_Editor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            nameText.Focus();
        }
        private void Login(object sender, System.EventArgs e)
        {
            if (nameText.Text == "admin" && passwordText.Text == "admin")
            {
                MessageBox.Show("登陆成功，欢迎使用简单文本编辑器。", "成功");
                nameLabel.Visible = false;
                nameText.Visible = false;
                passwordLabel.Visible = false;
                passwordText.Visible = false;
                loginButton.Visible = false;
                resetButton.Visible = false;
                returnButton.Visible = true;
                saveButton.Visible = true;
                textEditor.Visible = true;
            }
            else
            {
                MessageBox.Show("登录失败，用户名或密码错误。", "失败");
                nameText.Clear();
                passwordText.Clear();
                nameText.Focus();
            }
        }
        private void ResetLogin(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("确认清空？", "确认", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                nameText.Clear();
                passwordText.Clear();
            }
        }

        private void ChangeReturn(object sender, System.EventArgs e)
        {
            if (returnButton.Text == "自动换行")
            {
                textEditor.WordWrap = true;
                returnButton.Text = "不自动换行";
            }
            else
            {
                textEditor.WordWrap = false;
                returnButton.Text = "自动换行";
            }
        }
        private void Save(object sender, System.EventArgs e)
        {
            using FileStream writeFile = new("文本文件.txt", FileMode.Create, FileAccess.Write);
            byte[] buffer = Encoding.Default.GetBytes(textEditor.Text);
            writeFile.Write(buffer);
            MessageBox.Show("保存成功。", "成功");
        }
    }
}