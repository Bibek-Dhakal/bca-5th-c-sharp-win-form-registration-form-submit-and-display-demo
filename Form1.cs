namespace Registration_form_submit_and_display_demo;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        Resize += Form1_Resize;
        CenterPanel();
    }

    private void Form1_Resize(object? sender, EventArgs e)
    {
        CenterPanel();
    }

    private void CenterPanel()
    {
        panel1.Location = new Point(
            (ClientSize.Width - panel1.Width) / 2,
            (ClientSize.Height - panel1.Height) / 2
        );
    }

    private void button1_Click(object sender, EventArgs e)
    {
        var name = textBox1.Text;
        var email = textBox2.Text;
        var password = textBox3.Text;

        if (name == "" || email == "" || password == "")
        {
            MessageBox.Show("All fields are required");
            return;
        }

        MessageBox.Show("Name: " + name + "\nEmail: " + email + "\nPassword: " + password);
    }
}