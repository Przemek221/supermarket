namespace supermarket;
using System.Windows.Forms;


public class cash_register : Form
{
    
	public cash_register(Form form, int x = 231,int  y= 62)
    {
        ProgressBar progressBar= new ProgressBar();
        progressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
        progressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
        progressBar.Location = new System.Drawing.Point(6, 41);
        progressBar.MarqueeAnimationSpeed = 10;
        progressBar.Maximum = 15;
        progressBar.Name = "progressBar";
        progressBar.Size = new System.Drawing.Size(188, 22);
        progressBar.TabIndex = 3;
        progressBar.Value = 1;

        Label label=new Label();
        label.AutoSize = true;
        label.Location = new System.Drawing.Point(45, 23);
        label.Name = "label";
        label.Size = new System.Drawing.Size(131, 15);
        label.TabIndex = 4;
        label.Text = "customers in the queue";



        Label NumberOfCustomersInTheQueue=new Label();
        NumberOfCustomersInTheQueue.Location = new System.Drawing.Point(6, 23);
        NumberOfCustomersInTheQueue.Name = "NumberOfCustomersInTheQueue";
        NumberOfCustomersInTheQueue.Size = new System.Drawing.Size(33, 15);
        NumberOfCustomersInTheQueue.TabIndex = 5;
        NumberOfCustomersInTheQueue.Text = "x";



        GroupBox cash= new System.Windows.Forms.GroupBox();
        cash.BackColor = System.Drawing.SystemColors.Info;
        cash.Location = new System.Drawing.Point(x, y);
        cash.Name = "CashRegister";
        cash.Size = new System.Drawing.Size(200, 70);
        cash.TabIndex = 8;
        cash.TabStop = false;
        cash.Text = "CashRegister";

        //this makes that things are added to the groupbox
        cash.Controls.Add(NumberOfCustomersInTheQueue);
        cash.Controls.Add(label);
        cash.Controls.Add(progressBar);


        form.Controls.Add(cash);
    }

}