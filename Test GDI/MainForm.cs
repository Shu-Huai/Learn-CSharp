using System;
using System.Drawing;
using System.Windows.Forms;
namespace Verification_Code
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void Repaint(object sender, PaintEventArgs e)
        {
        }

        private void ChangeVerificationCode(object sender, EventArgs e)
        {
            Random randomGetter = new();
            string result = "";
            Bitmap bmp = new(150, 60);
            Graphics graphics = Graphics.FromImage(bmp);
            verificationCode.Image = bmp;
            for (int i = 0; i < 5; i++)
            {
                result += randomGetter.Next(0, 10);
                string[] fonts = { "微软雅黑", "宋体", "黑体", "隶书", "Times New Roman", "仿宋", "楷体", "幼圆" };
                Color[] colors = { Color.Yellow, Color.Red, Color.Black, Color.Orange, Color.Blue, Color.Green, Color.AliceBlue, Color.Azure };
                graphics.DrawString(randomGetter.Next(0, 10).ToString(),
                    new Font(fonts[randomGetter.Next(0, fonts.Length)], 40, FontStyle.Bold), new SolidBrush(colors[randomGetter.Next(0, colors.Length)]),
                    new Point(i * 25, 0));
            }
            for (int i = 0; i < 15; i++)
            {
                graphics.DrawLine(new Pen(Brushes.DarkBlue, 2),
                    new Point(randomGetter.Next(0, bmp.Width), randomGetter.Next(0, bmp.Height)), new Point(randomGetter.Next(0, bmp.Width), randomGetter.Next(0, bmp.Height)));
            }
            for (int i=0;i<50;i++)
            {
                bmp.SetPixel(randomGetter.Next(0, bmp.Width), randomGetter.Next(0, bmp.Height), Color.Black);
            }
        }
    }
}