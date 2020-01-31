namespace MoveBetweenListBoxes
{
    partial class CustomerForm
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
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.MoveItemLeftToRightButton = new System.Windows.Forms.Button();
            this.MoveItemRightToLeftButton = new System.Windows.Forms.Button();
            this.GetCustomersButton1 = new System.Windows.Forms.Button();
            this.GetCustomersButton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(19, 18);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(194, 173);
            this.listBox1.Sorted = true;
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(325, 18);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(194, 173);
            this.listBox2.Sorted = true;
            this.listBox2.TabIndex = 1;
            // 
            // MoveItemLeftToRightButton
            // 
            this.MoveItemLeftToRightButton.Location = new System.Drawing.Point(231, 29);
            this.MoveItemLeftToRightButton.Name = "MoveItemLeftToRightButton";
            this.MoveItemLeftToRightButton.Size = new System.Drawing.Size(75, 23);
            this.MoveItemLeftToRightButton.TabIndex = 2;
            this.MoveItemLeftToRightButton.Text = ">";
            this.MoveItemLeftToRightButton.UseVisualStyleBackColor = true;
            this.MoveItemLeftToRightButton.Click += new System.EventHandler(this.MoveItemLeftToRightButton_Click);
            // 
            // MoveItemRightToLeftButton
            // 
            this.MoveItemRightToLeftButton.Location = new System.Drawing.Point(231, 58);
            this.MoveItemRightToLeftButton.Name = "MoveItemRightToLeftButton";
            this.MoveItemRightToLeftButton.Size = new System.Drawing.Size(75, 23);
            this.MoveItemRightToLeftButton.TabIndex = 3;
            this.MoveItemRightToLeftButton.Text = "<";
            this.MoveItemRightToLeftButton.UseVisualStyleBackColor = true;
            this.MoveItemRightToLeftButton.Click += new System.EventHandler(this.MoveItemRightToLeftButton_Click);
            // 
            // GetCustomersButton1
            // 
            this.GetCustomersButton1.Location = new System.Drawing.Point(19, 197);
            this.GetCustomersButton1.Name = "GetCustomersButton1";
            this.GetCustomersButton1.Size = new System.Drawing.Size(194, 23);
            this.GetCustomersButton1.TabIndex = 4;
            this.GetCustomersButton1.Text = "Get customers";
            this.GetCustomersButton1.UseVisualStyleBackColor = true;
            this.GetCustomersButton1.Click += new System.EventHandler(this.GetCustomersButton1_Click);
            // 
            // GetCustomersButton2
            // 
            this.GetCustomersButton2.Location = new System.Drawing.Point(325, 197);
            this.GetCustomersButton2.Name = "GetCustomersButton2";
            this.GetCustomersButton2.Size = new System.Drawing.Size(194, 23);
            this.GetCustomersButton2.TabIndex = 5;
            this.GetCustomersButton2.Text = "Get customers";
            this.GetCustomersButton2.UseVisualStyleBackColor = true;
            this.GetCustomersButton2.Click += new System.EventHandler(this.GetCustomersButton2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 231);
            this.Controls.Add(this.GetCustomersButton2);
            this.Controls.Add(this.GetCustomersButton1);
            this.Controls.Add(this.MoveItemRightToLeftButton);
            this.Controls.Add(this.MoveItemLeftToRightButton);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BindingList/ListBox move Customers";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button MoveItemLeftToRightButton;
        private System.Windows.Forms.Button MoveItemRightToLeftButton;
        private System.Windows.Forms.Button GetCustomersButton1;
        private System.Windows.Forms.Button GetCustomersButton2;
    }
}

