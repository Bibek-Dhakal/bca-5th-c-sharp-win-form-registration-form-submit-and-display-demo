namespace Registration_form_submit_and_display_demo;

partial class Form1
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        panel1 = new System.Windows.Forms.Panel();
        label3 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        label1 = new System.Windows.Forms.Label();
        button1 = new System.Windows.Forms.Button();
        textBox3 = new System.Windows.Forms.TextBox();
        textBox2 = new System.Windows.Forms.TextBox();
        textBox1 = new System.Windows.Forms.TextBox();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.Controls.Add(label3);
        panel1.Controls.Add(label2);
        panel1.Controls.Add(label1);
        panel1.Controls.Add(button1);
        panel1.Controls.Add(textBox3);
        panel1.Controls.Add(textBox2);
        panel1.Controls.Add(textBox1);
        panel1.Location = new System.Drawing.Point(156, 39);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(473, 348);
        panel1.TabIndex = 0;
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(92, 198);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(76, 27);
        label3.TabIndex = 6;
        label3.Text = "Password";
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(92, 116);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(66, 27);
        label2.TabIndex = 5;
        label2.Text = "Email";
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(92, 34);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(66, 27);
        label1.TabIndex = 4;
        label1.Text = "Name";
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(186, 285);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(114, 32);
        button1.TabIndex = 3;
        button1.Text = "Submit";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // textBox3
        // 
        textBox3.Location = new System.Drawing.Point(92, 228);
        textBox3.Name = "textBox3";
        textBox3.Size = new System.Drawing.Size(289, 27);
        textBox3.TabIndex = 2;
        // 
        // textBox2
        // 
        textBox2.Location = new System.Drawing.Point(92, 146);
        textBox2.Name = "textBox2";
        textBox2.Size = new System.Drawing.Size(289, 27);
        textBox2.TabIndex = 1;
        // 
        // textBox1
        // 
        textBox1.Location = new System.Drawing.Point(92, 64);
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(289, 27);
        textBox1.TabIndex = 0;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(panel1);
        Text = "Form1";
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.TextBox textBox3;
    private System.Windows.Forms.Button button1;

    private System.Windows.Forms.Panel panel1;

    #endregion
}