namespace ListBoxDataBinding
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CorrectButton = new System.Windows.Forms.Button();
            this.InCorrectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CorrectButton
            // 
            this.CorrectButton.Location = new System.Drawing.Point(14, 20);
            this.CorrectButton.Name = "CorrectButton";
            this.CorrectButton.Size = new System.Drawing.Size(173, 23);
            this.CorrectButton.TabIndex = 0;
            this.CorrectButton.Text = "Correct";
            this.CorrectButton.UseVisualStyleBackColor = true;
            this.CorrectButton.Click += new System.EventHandler(this.CorrectButton_Click);
            // 
            // InCorrectButton
            // 
            this.InCorrectButton.Location = new System.Drawing.Point(207, 20);
            this.InCorrectButton.Name = "InCorrectButton";
            this.InCorrectButton.Size = new System.Drawing.Size(173, 23);
            this.InCorrectButton.TabIndex = 1;
            this.InCorrectButton.Text = "Incorrect";
            this.InCorrectButton.UseVisualStyleBackColor = true;
            this.InCorrectButton.Click += new System.EventHandler(this.InCorrectButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 69);
            this.Controls.Add(this.InCorrectButton);
            this.Controls.Add(this.CorrectButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CorrectButton;
        private System.Windows.Forms.Button InCorrectButton;
    }
}