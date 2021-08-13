
namespace Verification_Code
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
            this.verificationCode = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.verificationCode)).BeginInit();
            this.SuspendLayout();
            // 
            // verificationCode
            // 
            this.verificationCode.BackColor = System.Drawing.SystemColors.Control;
            this.verificationCode.Location = new System.Drawing.Point(12, 12);
            this.verificationCode.Name = "verificationCode";
            this.verificationCode.Size = new System.Drawing.Size(150, 60);
            this.verificationCode.TabIndex = 0;
            this.verificationCode.TabStop = false;
            this.verificationCode.Click += new System.EventHandler(this.ChangeVerificationCode);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 502);
            this.Controls.Add(this.verificationCode);
            this.Name = "MainForm";
            this.Text = "验证码";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Repaint);
            ((System.ComponentModel.ISupportInitialize)(this.verificationCode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox verificationCode;
    }
}

