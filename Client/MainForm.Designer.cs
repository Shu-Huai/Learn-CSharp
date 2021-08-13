
namespace Client
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
            this.connectButton = new System.Windows.Forms.Button();
            this.sendButton = new System.Windows.Forms.Button();
            this.IPEditor = new System.Windows.Forms.TextBox();
            this.portEditor = new System.Windows.Forms.TextBox();
            this.logEditor = new System.Windows.Forms.TextBox();
            this.messageEditor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // connectButton
            // 
            this.connectButton.AutoSize = true;
            this.connectButton.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.connectButton.Location = new System.Drawing.Point(228, 12);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(91, 26);
            this.connectButton.TabIndex = 0;
            this.connectButton.Text = "连接";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.Connect);
            // 
            // sendButton
            // 
            this.sendButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sendButton.AutoSize = true;
            this.sendButton.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sendButton.Location = new System.Drawing.Point(841, 463);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(91, 26);
            this.sendButton.TabIndex = 1;
            this.sendButton.Text = "发送消息";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.SendMessage);
            // 
            // IPEditor
            // 
            this.IPEditor.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IPEditor.Location = new System.Drawing.Point(12, 12);
            this.IPEditor.Name = "IPEditor";
            this.IPEditor.Size = new System.Drawing.Size(141, 26);
            this.IPEditor.TabIndex = 2;
            // 
            // portEditor
            // 
            this.portEditor.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.portEditor.Location = new System.Drawing.Point(159, 12);
            this.portEditor.Name = "portEditor";
            this.portEditor.Size = new System.Drawing.Size(63, 26);
            this.portEditor.TabIndex = 3;
            // 
            // logEditor
            // 
            this.logEditor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logEditor.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.logEditor.Location = new System.Drawing.Point(12, 44);
            this.logEditor.Multiline = true;
            this.logEditor.Name = "logEditor";
            this.logEditor.ReadOnly = true;
            this.logEditor.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.logEditor.Size = new System.Drawing.Size(920, 140);
            this.logEditor.TabIndex = 4;
            this.logEditor.WordWrap = false;
            // 
            // messageEditor
            // 
            this.messageEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messageEditor.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.messageEditor.Location = new System.Drawing.Point(12, 190);
            this.messageEditor.Multiline = true;
            this.messageEditor.Name = "messageEditor";
            this.messageEditor.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.messageEditor.Size = new System.Drawing.Size(920, 267);
            this.messageEditor.TabIndex = 5;
            this.messageEditor.WordWrap = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.messageEditor);
            this.Controls.Add(this.logEditor);
            this.Controls.Add(this.portEditor);
            this.Controls.Add(this.IPEditor);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.connectButton);
            this.MinimumSize = new System.Drawing.Size(960, 540);
            this.Name = "MainForm";
            this.Text = "客户端";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.TextBox IPEditor;
        private System.Windows.Forms.TextBox portEditor;
        private System.Windows.Forms.TextBox logEditor;
        private System.Windows.Forms.TextBox messageEditor;
    }
}

