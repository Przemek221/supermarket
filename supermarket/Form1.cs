namespace supermarket;

// M- no. of cash registers

public partial class Form1 : Form
{
    cash_register array=null;
    public Form1()
    {
        InitializeComponent();
    }

    private void start_Click(object sender, EventArgs e)
    {
        /*MessageBox.Show("started");*/
        int x= (int)M.Value;int y=62;

        /*
        abc.Location = new System.Drawing.Point(210, 10);
        cash_register abc1 = new cash_register(this,231,162);
        abc1.Location = new System.Drawing.Point(300, 15);
        */


        for (int i = 0; i < x; i++)
        {
            cash_register abc = new cash_register(this, 231, y);
            y += 100;
        }


    }

    private void label1_Click(object sender, EventArgs e)
    {
        TextBox field1 = new TextBox()
        {
            Location = new Point(100, 10),
            TabIndex = 11
        };

        Controls.Add(field1);
    }


    private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
    {

    }

    private void groupBox3_Enter(object sender, EventArgs e)
    {

    }

    private void label2_Click_1(object sender, EventArgs e)
    {

    }

    private void label3_Click(object sender, EventArgs e)
    {
    }

    private void stop_Click(object sender, EventArgs e)
    {
        Application.Exit();
        //Application.Restart();
    }

    private void progressBar1_Click(object sender, EventArgs e)
    {
    }

    private void label3_Click_1(object sender, EventArgs e)
    {

        customer aa = new customer();
        label3.Text = aa.function();
    }

}