using System;
using System.Windows.Forms;
namespace Date_Selector
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            for (int i = DateTime.Now.Year; i >= 1949; i--)
            {
                yearCombo.Items.Add(i + "年");
            }
        }
        private void AddMonth(object sender, EventArgs e)
        {
            monthCombo.Items.Clear();
            dayCombo.Items.Clear();
            for (int i = 1; i <= 12; i++)
            {
                monthCombo.Items.Add(i + "月");
            }
        }
        private void AddDay(object sender, EventArgs e)
        {
            dayCombo.Items.Clear();
            int year = int.Parse(yearCombo.SelectedItem.ToString().Split(new char[] { '年' }, StringSplitOptions.RemoveEmptyEntries)[0]);
            int month = int.Parse(monthCombo.SelectedItem.ToString().Split(new char[] { '月' }, StringSplitOptions.RemoveEmptyEntries)[0]);
            int day;
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    day = 31;
                    break;
                case 2:
                    day = year % 400 == 0 || (year % 4 == 0 && year % 100 != 0) ? 29 : 28;
                    break;
                default:
                    day = 30;
                    break;
            }
            for (int i = 1; i <= day; i++)
            {
                dayCombo.Items.Add(i + "日");
            }
        }
    }
}