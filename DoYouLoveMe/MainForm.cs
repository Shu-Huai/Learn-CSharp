using System;
using System.Windows.Forms;
using System.Drawing;
namespace Do_You_Love_Me
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            timeLabel.Text = $"当前时间{DateTime.Now}。";
        }
        private void MoveMouse(object sender, System.EventArgs e)
        {
            int maxWidth = ClientSize.Width - noButton.Width;
            int maxHeight = ClientSize.Height - noButton.Height;
            Random randomGetter = new();
            int xCoordinate = randomGetter.Next(0, maxWidth);
            int yCoordinate = randomGetter.Next(0, maxHeight);
            while ((xCoordinate > loveButton.Location.X - noButton.Width && xCoordinate < loveButton.Location.X + loveButton.Width
                && yCoordinate > loveButton.Location.Y - noButton.Height && yCoordinate < loveButton.Location.Y + loveButton.Height)
                || (xCoordinate > noButton.Location.X - noButton.Width && xCoordinate < noButton.Location.X + noButton.Width
                && yCoordinate > noButton.Location.Y - noButton.Height && yCoordinate < noButton.Location.Y + noButton.Height)
                || (xCoordinate > questionLabel.Location.X - noButton.Width && xCoordinate < questionLabel.Location.X + questionLabel.Width
                && yCoordinate > questionLabel.Location.Y - noButton.Height && yCoordinate < questionLabel.Location.Y + questionLabel.Height)
                || (xCoordinate > timeLabel.Location.X - noButton.Width && xCoordinate < timeLabel.Location.X + timeLabel.Width
                && yCoordinate > timeLabel.Location.Y - noButton.Height && yCoordinate < timeLabel.Location.Y + timeLabel.Height))
            {
                xCoordinate = randomGetter.Next(0, maxWidth);
                yCoordinate = randomGetter.Next(0, maxHeight);
            }
            noButton.Location = new Point(xCoordinate, yCoordinate);
        }
        private void RejectLoveToo(object sender, System.EventArgs e)
        {
            MessageBox.Show("我也爱你。");
            Close();
        }
        private void DisplayTime(object sender, EventArgs e)
        {
            timeLabel.Text = $"当前时间{DateTime.Now}。";
        }
    }
}