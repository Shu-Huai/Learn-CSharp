using System.Windows.Forms;
namespace WinForms_Hello_World_
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void RejectHelloWorld(object sender, System.EventArgs e)
        {
            MessageBox.Show("Hello World!");
        }
    }
}