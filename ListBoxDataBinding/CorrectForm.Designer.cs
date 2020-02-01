namespace ListBoxDataBinding
{
    partial class CorrectForm
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
            this.ListCountLabel = new System.Windows.Forms.Label();
            this.AddCustomerButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddLastNameTextBox = new System.Windows.Forms.TextBox();
            this.AddFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.CustomerListBox = new System.Windows.Forms.ListBox();
            this.EditCustomerButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EditLastNameTextBox = new System.Windows.Forms.TextBox();
            this.EditFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListCountLabel
            // 
            this.ListCountLabel.AutoSize = true;
            this.ListCountLabel.Location = new System.Drawing.Point(12, 224);
            this.ListCountLabel.Name = "ListCountLabel";
            this.ListCountLabel.Size = new System.Drawing.Size(37, 13);
            this.ListCountLabel.TabIndex = 16;
            this.ListCountLabel.Text = "Status";
            // 
            // AddCustomerButton
            // 
            this.AddCustomerButton.Location = new System.Drawing.Point(230, 21);
            this.AddCustomerButton.Name = "AddCustomerButton";
            this.AddCustomerButton.Size = new System.Drawing.Size(200, 23);
            this.AddCustomerButton.TabIndex = 15;
            this.AddCustomerButton.Text = "Add new Customer";
            this.AddCustomerButton.UseVisualStyleBackColor = true;
            this.AddCustomerButton.Click += new System.EventHandler(this.AddCustomerButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Last name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "First name";
            // 
            // AddLastNameTextBox
            // 
            this.AddLastNameTextBox.Location = new System.Drawing.Point(82, 54);
            this.AddLastNameTextBox.Name = "AddLastNameTextBox";
            this.AddLastNameTextBox.Size = new System.Drawing.Size(142, 20);
            this.AddLastNameTextBox.TabIndex = 12;
            this.AddLastNameTextBox.Text = "Payne";
            // 
            // AddFirstNameTextBox
            // 
            this.AddFirstNameTextBox.Location = new System.Drawing.Point(82, 21);
            this.AddFirstNameTextBox.Name = "AddFirstNameTextBox";
            this.AddFirstNameTextBox.Size = new System.Drawing.Size(142, 20);
            this.AddFirstNameTextBox.TabIndex = 11;
            this.AddFirstNameTextBox.Text = "Karen";
            // 
            // CustomerListBox
            // 
            this.CustomerListBox.FormattingEnabled = true;
            this.CustomerListBox.Location = new System.Drawing.Point(11, 12);
            this.CustomerListBox.Name = "CustomerListBox";
            this.CustomerListBox.Size = new System.Drawing.Size(209, 186);
            this.CustomerListBox.TabIndex = 10;
            // 
            // EditCustomerButton
            // 
            this.EditCustomerButton.Enabled = false;
            this.EditCustomerButton.Location = new System.Drawing.Point(231, 20);
            this.EditCustomerButton.Name = "EditCustomerButton";
            this.EditCustomerButton.Size = new System.Drawing.Size(200, 23);
            this.EditCustomerButton.TabIndex = 17;
            this.EditCustomerButton.Text = "Edit Current customer";
            this.EditCustomerButton.UseVisualStyleBackColor = true;
            this.EditCustomerButton.Click += new System.EventHandler(this.EditCustomerButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Last name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "First name";
            // 
            // EditLastNameTextBox
            // 
            this.EditLastNameTextBox.Location = new System.Drawing.Point(83, 53);
            this.EditLastNameTextBox.Name = "EditLastNameTextBox";
            this.EditLastNameTextBox.Size = new System.Drawing.Size(142, 20);
            this.EditLastNameTextBox.TabIndex = 19;
            this.EditLastNameTextBox.Text = "Smith";
            // 
            // EditFirstNameTextBox
            // 
            this.EditFirstNameTextBox.Location = new System.Drawing.Point(83, 20);
            this.EditFirstNameTextBox.Name = "EditFirstNameTextBox";
            this.EditFirstNameTextBox.Size = new System.Drawing.Size(142, 20);
            this.EditFirstNameTextBox.TabIndex = 18;
            this.EditFirstNameTextBox.Text = "Mary";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddCustomerButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.AddLastNameTextBox);
            this.groupBox1.Controls.Add(this.AddFirstNameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(243, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 84);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add customer";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.EditLastNameTextBox);
            this.groupBox2.Controls.Add(this.EditFirstNameTextBox);
            this.groupBox2.Controls.Add(this.EditCustomerButton);
            this.groupBox2.Location = new System.Drawing.Point(242, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(472, 77);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edit current";
            // 
            // CorrectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 287);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ListCountLabel);
            this.Controls.Add(this.CustomerListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CorrectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListBox data binding correct";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ListCountLabel;
        private System.Windows.Forms.Button AddCustomerButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AddLastNameTextBox;
        private System.Windows.Forms.TextBox AddFirstNameTextBox;
        private System.Windows.Forms.ListBox CustomerListBox;
        private System.Windows.Forms.Button EditCustomerButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EditLastNameTextBox;
        private System.Windows.Forms.TextBox EditFirstNameTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}