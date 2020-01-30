namespace CommonPractice
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ExampleBaseButton = new System.Windows.Forms.Button();
            this.INotifyPropertyChangedButton = new System.Windows.Forms.Button();
            this.JetBrainsINotifyPropertyChangedButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CommonSolutionNonBindingSourceButton = new System.Windows.Forms.Button();
            this.ResultsTextBox = new System.Windows.Forms.TextBox();
            this.CurrentPersonButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ColorsComboBox1 = new System.Windows.Forms.ComboBox();
            this.ColorsComboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(18, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(210, 134);
            this.listBox1.TabIndex = 0;
            // 
            // ExampleBaseButton
            // 
            this.ExampleBaseButton.Location = new System.Drawing.Point(29, 25);
            this.ExampleBaseButton.Name = "ExampleBaseButton";
            this.ExampleBaseButton.Size = new System.Drawing.Size(228, 23);
            this.ExampleBaseButton.TabIndex = 1;
            this.ExampleBaseButton.Text = "Example base";
            this.ExampleBaseButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExampleBaseButton.UseVisualStyleBackColor = true;
            this.ExampleBaseButton.Click += new System.EventHandler(this.ExampleBaseButton_Click);
            // 
            // INotifyPropertyChangedButton
            // 
            this.INotifyPropertyChangedButton.Location = new System.Drawing.Point(29, 54);
            this.INotifyPropertyChangedButton.Name = "INotifyPropertyChangedButton";
            this.INotifyPropertyChangedButton.Size = new System.Drawing.Size(228, 23);
            this.INotifyPropertyChangedButton.TabIndex = 2;
            this.INotifyPropertyChangedButton.Text = "Example INotifyPropertyChanged";
            this.INotifyPropertyChangedButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.INotifyPropertyChangedButton.UseVisualStyleBackColor = true;
            this.INotifyPropertyChangedButton.Click += new System.EventHandler(this.INotifyPropertyChangedButton_Click);
            // 
            // JetBrainsINotifyPropertyChangedButton
            // 
            this.JetBrainsINotifyPropertyChangedButton.Location = new System.Drawing.Point(29, 83);
            this.JetBrainsINotifyPropertyChangedButton.Name = "JetBrainsINotifyPropertyChangedButton";
            this.JetBrainsINotifyPropertyChangedButton.Size = new System.Drawing.Size(228, 23);
            this.JetBrainsINotifyPropertyChangedButton.TabIndex = 3;
            this.JetBrainsINotifyPropertyChangedButton.Text = "Example JetBrains INotifyPropertyChanged";
            this.JetBrainsINotifyPropertyChangedButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.JetBrainsINotifyPropertyChangedButton.UseVisualStyleBackColor = true;
            this.JetBrainsINotifyPropertyChangedButton.Click += new System.EventHandler(this.JetBrainsINotifyPropertyChangedButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.JetBrainsINotifyPropertyChangedButton);
            this.groupBox1.Controls.Add(this.INotifyPropertyChangedButton);
            this.groupBox1.Controls.Add(this.ExampleBaseButton);
            this.groupBox1.Location = new System.Drawing.Point(234, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 138);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BindingSource";
            // 
            // CommonSolutionNonBindingSourceButton
            // 
            this.CommonSolutionNonBindingSourceButton.Location = new System.Drawing.Point(529, 37);
            this.CommonSolutionNonBindingSourceButton.Name = "CommonSolutionNonBindingSourceButton";
            this.CommonSolutionNonBindingSourceButton.Size = new System.Drawing.Size(228, 23);
            this.CommonSolutionNonBindingSourceButton.TabIndex = 4;
            this.CommonSolutionNonBindingSourceButton.Text = "Common solution";
            this.CommonSolutionNonBindingSourceButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CommonSolutionNonBindingSourceButton.UseVisualStyleBackColor = true;
            this.CommonSolutionNonBindingSourceButton.Click += new System.EventHandler(this.CommonSolutionNonBindingSourceButton_Click);
            // 
            // ResultsTextBox
            // 
            this.ResultsTextBox.Location = new System.Drawing.Point(22, 160);
            this.ResultsTextBox.Multiline = true;
            this.ResultsTextBox.Name = "ResultsTextBox";
            this.ResultsTextBox.Size = new System.Drawing.Size(206, 142);
            this.ResultsTextBox.TabIndex = 5;
            // 
            // CurrentPersonButton
            // 
            this.CurrentPersonButton.Location = new System.Drawing.Point(529, 66);
            this.CurrentPersonButton.Name = "CurrentPersonButton";
            this.CurrentPersonButton.Size = new System.Drawing.Size(228, 23);
            this.CurrentPersonButton.TabIndex = 6;
            this.CurrentPersonButton.Text = "Get current";
            this.CurrentPersonButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CurrentPersonButton.UseVisualStyleBackColor = true;
            this.CurrentPersonButton.Click += new System.EventHandler(this.CurrentPersonButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ColorsComboBox2);
            this.groupBox2.Controls.Add(this.ColorsComboBox1);
            this.groupBox2.Location = new System.Drawing.Point(23, 312);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(626, 110);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Colors";
            // 
            // ColorsComboBox1
            // 
            this.ColorsComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ColorsComboBox1.FormattingEnabled = true;
            this.ColorsComboBox1.Location = new System.Drawing.Point(14, 33);
            this.ColorsComboBox1.Name = "ColorsComboBox1";
            this.ColorsComboBox1.Size = new System.Drawing.Size(139, 21);
            this.ColorsComboBox1.TabIndex = 0;
            // 
            // ColorsComboBox2
            // 
            this.ColorsComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ColorsComboBox2.FormattingEnabled = true;
            this.ColorsComboBox2.Location = new System.Drawing.Point(181, 33);
            this.ColorsComboBox2.Name = "ColorsComboBox2";
            this.ColorsComboBox2.Size = new System.Drawing.Size(139, 21);
            this.ColorsComboBox2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.CurrentPersonButton);
            this.Controls.Add(this.ResultsTextBox);
            this.Controls.Add(this.CommonSolutionNonBindingSourceButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Common practice";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button ExampleBaseButton;
        private System.Windows.Forms.Button INotifyPropertyChangedButton;
        private System.Windows.Forms.Button JetBrainsINotifyPropertyChangedButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button CommonSolutionNonBindingSourceButton;
        private System.Windows.Forms.TextBox ResultsTextBox;
        private System.Windows.Forms.Button CurrentPersonButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox ColorsComboBox1;
        private System.Windows.Forms.ComboBox ColorsComboBox2;
    }
}

