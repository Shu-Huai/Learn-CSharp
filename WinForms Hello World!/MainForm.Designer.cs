
namespace WinForms_Hello_World_
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
            this.helloWorldLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // helloWorldLabel
            // 
            this.helloWorldLabel.AutoSize = true;
            this.helloWorldLabel.Location = new System.Drawing.Point(12, 9);
            this.helloWorldLabel.Name = "helloWorldLabel";
            this.helloWorldLabel.Size = new System.Drawing.Size(82, 17);
            this.helloWorldLabel.TabIndex = 0;
            this.helloWorldLabel.Text = "Hello World!";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.helloWorldLabel);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label helloWorldLabel;
    }
}

