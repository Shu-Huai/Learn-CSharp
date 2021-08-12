using System;
using System.Windows.Forms;
namespace WinForms_Hello_World_
{
    static class WinFormsHelloWorld
    {
        [STAThread]
        public static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}