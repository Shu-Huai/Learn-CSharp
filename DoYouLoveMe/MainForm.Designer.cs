namespace Do_You_Love_Me
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
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
            this.loveButton = new System.Windows.Forms.Button();
            this.noButton = new System.Windows.Forms.Button();
            this.questionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loveButton
            // 
            this.loveButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loveButton.AutoSize = true;
            this.loveButton.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loveButton.Location = new System.Drawing.Point(128, 132);
            this.loveButton.Name = "loveButton";
            this.loveButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.loveButton.Size = new System.Drawing.Size(75, 26);
            this.loveButton.TabIndex = 0;
            this.loveButton.Text = "爱";
            this.loveButton.UseVisualStyleBackColor = true;
            this.loveButton.Click += new System.EventHandler(this.RejectLoveToo);
            // 
            // noButton
            // 
            this.noButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.noButton.AutoSize = true;
            this.noButton.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.noButton.Location = new System.Drawing.Point(301, 132);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(75, 26);
            this.noButton.TabIndex = 1;
            this.noButton.Text = "不爱";
            this.noButton.UseVisualStyleBackColor = true;
            this.noButton.MouseEnter += new System.EventHandler(this.MoveMouse);
            // 
            // questionLabel
            // 
            this.questionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.questionLabel.AutoSize = true;
            this.questionLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.questionLabel.Location = new System.Drawing.Point(128, 79);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(87, 16);
            this.questionLabel.TabIndex = 2;
            this.questionLabel.Text = "你爱我吗？";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 302);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.noButton);
            this.Controls.Add(this.loveButton);
            this.MinimumSize = new System.Drawing.Size(480, 270);
            this.Name = "MainForm";
            this.Text = "你爱我吗？";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loveButton;
        private System.Windows.Forms.Button noButton;
        private System.Windows.Forms.Label questionLabel;
    }
}