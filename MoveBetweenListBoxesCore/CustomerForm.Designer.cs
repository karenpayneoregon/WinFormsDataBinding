namespace MoveBetweenListBoxesCore;

partial class CustomerForm
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
        listBox1 = new ListBox();
        listBox2 = new ListBox();
        MoveItemLeftToRightButton = new Button();
        MoveItemRightToLeftButton = new Button();
        GetCustomersButton1 = new Button();
        GetCustomersButton2 = new Button();
        SuspendLayout();
        // 
        // listBox1
        // 
        listBox1.FormattingEnabled = true;
        listBox1.Location = new Point(19, 18);
        listBox1.Name = "listBox1";
        listBox1.Size = new Size(278, 164);
        listBox1.Sorted = true;
        listBox1.TabIndex = 0;
        // 
        // listBox2
        // 
        listBox2.FormattingEnabled = true;
        listBox2.Location = new Point(410, 18);
        listBox2.Name = "listBox2";
        listBox2.Size = new Size(278, 164);
        listBox2.Sorted = true;
        listBox2.TabIndex = 1;
        // 
        // MoveItemLeftToRightButton
        // 
        MoveItemLeftToRightButton.Image = Properties.Resources.right;
        MoveItemLeftToRightButton.Location = new Point(312, 38);
        MoveItemLeftToRightButton.Name = "MoveItemLeftToRightButton";
        MoveItemLeftToRightButton.Size = new Size(75, 28);
        MoveItemLeftToRightButton.TabIndex = 2;
        MoveItemLeftToRightButton.UseVisualStyleBackColor = true;
        MoveItemLeftToRightButton.Click += MoveItemLeftToRightButton_Click;
        // 
        // MoveItemRightToLeftButton
        // 
        MoveItemRightToLeftButton.Image = Properties.Resources.left;
        MoveItemRightToLeftButton.Location = new Point(312, 83);
        MoveItemRightToLeftButton.Name = "MoveItemRightToLeftButton";
        MoveItemRightToLeftButton.Size = new Size(75, 28);
        MoveItemRightToLeftButton.TabIndex = 3;
        MoveItemRightToLeftButton.UseVisualStyleBackColor = true;
        MoveItemRightToLeftButton.Click += MoveItemRightToLeftButton_Click;
        // 
        // GetCustomersButton1
        // 
        GetCustomersButton1.Location = new Point(19, 197);
        GetCustomersButton1.Name = "GetCustomersButton1";
        GetCustomersButton1.Size = new Size(278, 34);
        GetCustomersButton1.TabIndex = 4;
        GetCustomersButton1.Text = "Get customers";
        GetCustomersButton1.UseVisualStyleBackColor = true;
        GetCustomersButton1.Click += GetCustomersButton1_Click;
        // 
        // GetCustomersButton2
        // 
        GetCustomersButton2.Location = new Point(410, 197);
        GetCustomersButton2.Name = "GetCustomersButton2";
        GetCustomersButton2.Size = new Size(278, 34);
        GetCustomersButton2.TabIndex = 5;
        GetCustomersButton2.Text = "Get customers";
        GetCustomersButton2.UseVisualStyleBackColor = true;
        GetCustomersButton2.Click += GetCustomersButton2_Click;
        // 
        // CustomerForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(700, 247);
        Controls.Add(GetCustomersButton2);
        Controls.Add(GetCustomersButton1);
        Controls.Add(MoveItemRightToLeftButton);
        Controls.Add(MoveItemLeftToRightButton);
        Controls.Add(listBox2);
        Controls.Add(listBox1);
        FormBorderStyle = FormBorderStyle.FixedToolWindow;
        Name = "CustomerForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Move to and from ListBox";
        ResumeLayout(false);
    }

    #endregion
    private System.Windows.Forms.ListBox listBox1;
    private System.Windows.Forms.ListBox listBox2;
    private System.Windows.Forms.Button MoveItemLeftToRightButton;
    private System.Windows.Forms.Button MoveItemRightToLeftButton;
    private System.Windows.Forms.Button GetCustomersButton1;
    private System.Windows.Forms.Button GetCustomersButton2;
}
