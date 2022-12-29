namespace supermarket;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void start_Click(object sender, EventArgs e)
    {
        MessageBox.Show("siema");

        //label1.Update("siema");
        label1.Text = "siemaj;";
    }

    private void label1_Click(object sender, EventArgs e)
    {
    }
}