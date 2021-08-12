
namespace Date_Selector
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.yearCombo = new System.Windows.Forms.ComboBox();
            this.monthCombo = new System.Windows.Forms.ComboBox();
            this.dayCombo = new System.Windows.Forms.ComboBox();
            this.calender = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // yearCombo
            // 
            this.yearCombo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.yearCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yearCombo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.yearCombo.FormattingEnabled = true;
            this.yearCombo.Location = new System.Drawing.Point(12, 12);
            this.yearCombo.Name = "yearCombo";
            this.yearCombo.Size = new System.Drawing.Size(121, 24);
            this.yearCombo.TabIndex = 0;
            this.yearCombo.SelectedIndexChanged += new System.EventHandler(this.AddMonth);
            // 
            // monthCombo
            // 
            this.monthCombo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.monthCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.monthCombo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.monthCombo.FormattingEnabled = true;
            this.monthCombo.Location = new System.Drawing.Point(139, 12);
            this.monthCombo.Name = "monthCombo";
            this.monthCombo.Size = new System.Drawing.Size(121, 24);
            this.monthCombo.TabIndex = 1;
            this.monthCombo.SelectedIndexChanged += new System.EventHandler(this.AddDay);
            // 
            // dayCombo
            // 
            this.dayCombo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dayCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dayCombo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dayCombo.FormattingEnabled = true;
            this.dayCombo.Location = new System.Drawing.Point(266, 12);
            this.dayCombo.Name = "dayCombo";
            this.dayCombo.Size = new System.Drawing.Size(121, 24);
            this.dayCombo.TabIndex = 2;
            this.dayCombo.SelectedIndexChanged += new System.EventHandler(this.ShowInCalender);
            // 
            // calender
            // 
            this.calender.Location = new System.Drawing.Point(90, 48);
            this.calender.Name = "calender";
            this.calender.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 239);
            this.Controls.Add(this.calender);
            this.Controls.Add(this.dayCombo);
            this.Controls.Add(this.monthCombo);
            this.Controls.Add(this.yearCombo);
            this.MinimumSize = new System.Drawing.Size(414, 278);
            this.Name = "MainForm";
            this.Text = "日期选择器";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox yearCombo;
        private System.Windows.Forms.ComboBox monthCombo;
        private System.Windows.Forms.ComboBox dayCombo;
        private System.Windows.Forms.MonthCalendar calender;
    }
}

