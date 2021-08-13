
namespace Server
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
            this.IPEditor = new System.Windows.Forms.TextBox();
            this.portEditor = new System.Windows.Forms.TextBox();
            this.directoryEditor = new System.Windows.Forms.TextBox();
            this.messageEditor = new System.Windows.Forms.TextBox();
            this.logEditor = new System.Windows.Forms.TextBox();
            this.beginButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.selectButton = new System.Windows.Forms.Button();
            this.fileButton = new System.Windows.Forms.Button();
            this.messageButton = new System.Windows.Forms.Button();
            this.vibrateButton = new System.Windows.Forms.Button();
            this.IPCombo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // IPEditor
            // 
            this.IPEditor.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IPEditor.Location = new System.Drawing.Point(12, 12);
            this.IPEditor.Name = "IPEditor";
            this.IPEditor.Size = new System.Drawing.Size(141, 26);
            this.IPEditor.TabIndex = 0;
            this.IPEditor.Text = "192.168.1.115";
            // 
            // portEditor
            // 
            this.portEditor.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.portEditor.Location = new System.Drawing.Point(159, 12);
            this.portEditor.Name = "portEditor";
            this.portEditor.Size = new System.Drawing.Size(63, 26);
            this.portEditor.TabIndex = 1;
            this.portEditor.Text = "50000";
            // 
            // directoryEditor
            // 
            this.directoryEditor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.directoryEditor.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.directoryEditor.Location = new System.Drawing.Point(12, 463);
            this.directoryEditor.Name = "directoryEditor";
            this.directoryEditor.Size = new System.Drawing.Size(727, 26);
            this.directoryEditor.TabIndex = 2;
            // 
            // messageEditor
            // 
            this.messageEditor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messageEditor.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.messageEditor.Location = new System.Drawing.Point(12, 325);
            this.messageEditor.Multiline = true;
            this.messageEditor.Name = "messageEditor";
            this.messageEditor.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.messageEditor.Size = new System.Drawing.Size(920, 100);
            this.messageEditor.TabIndex = 3;
            this.messageEditor.WordWrap = false;
            // 
            // logEditor
            // 
            this.logEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logEditor.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.logEditor.Location = new System.Drawing.Point(12, 44);
            this.logEditor.Multiline = true;
            this.logEditor.Name = "logEditor";
            this.logEditor.ReadOnly = true;
            this.logEditor.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.logEditor.Size = new System.Drawing.Size(920, 275);
            this.logEditor.TabIndex = 4;
            this.logEditor.WordWrap = false;
            // 
            // beginButton
            // 
            this.beginButton.AutoSize = true;
            this.beginButton.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.beginButton.Location = new System.Drawing.Point(228, 12);
            this.beginButton.Name = "beginButton";
            this.beginButton.Size = new System.Drawing.Size(91, 26);
            this.beginButton.TabIndex = 5;
            this.beginButton.Text = "开始监听";
            this.beginButton.UseVisualStyleBackColor = true;
            this.beginButton.Click += new System.EventHandler(this.BeginWatch);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.AutoSize = true;
            this.button2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(841, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 26);
            this.button2.TabIndex = 6;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // selectButton
            // 
            this.selectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.selectButton.AutoSize = true;
            this.selectButton.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectButton.Location = new System.Drawing.Point(745, 463);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(90, 26);
            this.selectButton.TabIndex = 7;
            this.selectButton.Text = "选择";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.SelectFile);
            // 
            // fileButton
            // 
            this.fileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fileButton.AutoSize = true;
            this.fileButton.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fileButton.Location = new System.Drawing.Point(841, 463);
            this.fileButton.Name = "fileButton";
            this.fileButton.Size = new System.Drawing.Size(91, 26);
            this.fileButton.TabIndex = 8;
            this.fileButton.Text = "发送文件";
            this.fileButton.UseVisualStyleBackColor = true;
            this.fileButton.Click += new System.EventHandler(this.SendFile);
            // 
            // messageButton
            // 
            this.messageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.messageButton.AutoSize = true;
            this.messageButton.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.messageButton.Location = new System.Drawing.Point(841, 431);
            this.messageButton.Name = "messageButton";
            this.messageButton.Size = new System.Drawing.Size(91, 26);
            this.messageButton.TabIndex = 9;
            this.messageButton.Text = "发送消息";
            this.messageButton.UseVisualStyleBackColor = true;
            this.messageButton.Click += new System.EventHandler(this.SendMessage);
            // 
            // vibrateButton
            // 
            this.vibrateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.vibrateButton.AutoSize = true;
            this.vibrateButton.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vibrateButton.Location = new System.Drawing.Point(745, 431);
            this.vibrateButton.Name = "vibrateButton";
            this.vibrateButton.Size = new System.Drawing.Size(90, 26);
            this.vibrateButton.TabIndex = 10;
            this.vibrateButton.Text = "震动";
            this.vibrateButton.UseVisualStyleBackColor = true;
            this.vibrateButton.Click += new System.EventHandler(this.SendVibrate);
            // 
            // IPCombo
            // 
            this.IPCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IPCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IPCombo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IPCombo.FormattingEnabled = true;
            this.IPCombo.Location = new System.Drawing.Point(648, 12);
            this.IPCombo.Name = "IPCombo";
            this.IPCombo.Size = new System.Drawing.Size(187, 24);
            this.IPCombo.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.IPCombo);
            this.Controls.Add(this.vibrateButton);
            this.Controls.Add(this.messageButton);
            this.Controls.Add(this.fileButton);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.beginButton);
            this.Controls.Add(this.logEditor);
            this.Controls.Add(this.messageEditor);
            this.Controls.Add(this.directoryEditor);
            this.Controls.Add(this.portEditor);
            this.Controls.Add(this.IPEditor);
            this.MinimumSize = new System.Drawing.Size(960, 540);
            this.Name = "MainForm";
            this.Text = "服务端";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IPEditor;
        private System.Windows.Forms.TextBox portEditor;
        private System.Windows.Forms.TextBox directoryEditor;
        private System.Windows.Forms.TextBox messageEditor;
        private System.Windows.Forms.TextBox logEditor;
        private System.Windows.Forms.Button beginButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Button fileButton;
        private System.Windows.Forms.Button messageButton;
        private System.Windows.Forms.Button vibrateButton;
        private System.Windows.Forms.ComboBox IPCombo;
    }
}

