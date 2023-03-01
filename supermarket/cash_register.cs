namespace supermarket;

using System.Windows.Forms;
using System.Threading;

public class cash_register : Form
{
    private ProgressBar _progressBar;
    private Label _cashState;
    private Label _NumberOfCustomersInTheQueue;
    private GroupBox _cashBox;

    private bool _opened;
    private int _id;

    public GroupBox CashBox => _cashBox;
    public Semaphore semaphore = new Semaphore(1, 1);

    public bool isOpen => _opened;
    public bool isFull => (_progressBar.Value == _progressBar.Maximum) ? true : false;
    public bool isEmpty => (_progressBar.Value == 0) ? true : false;

    public cash_register(Form form, int x = 231, int y = 62, int number = 0) //constructs the cash
    {

        //progress bar visualising the queue
        _progressBar = new ProgressBar();
        _progressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
        _progressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
        _progressBar.Location = new System.Drawing.Point(6, 51);
        _progressBar.MarqueeAnimationSpeed = 10;
        _progressBar.Maximum = 15;
        _progressBar.Name = "progressBar";
        _progressBar.Size = new System.Drawing.Size(188, 22);
        _progressBar.TabIndex = 3;
        _progressBar.Value = 0;


        //just text
        _cashState = new Label();
        _cashState.AutoSize = true;
        _cashState.Location = new System.Drawing.Point(45, 23);
        _cashState.Name = "label";
        _cashState.Size = new System.Drawing.Size(131, 15);
        _cashState.TabIndex = 4;
        _cashState.Text = "customers in the queue";


        //specifies number of customers in the queue
        _NumberOfCustomersInTheQueue = new Label();
        _NumberOfCustomersInTheQueue.Location = new System.Drawing.Point(6, 23);
        _NumberOfCustomersInTheQueue.Name = "NumberOfCustomersInTheQueue";
        _NumberOfCustomersInTheQueue.Size = new System.Drawing.Size(33, 15);
        _NumberOfCustomersInTheQueue.TabIndex = 5;
        _NumberOfCustomersInTheQueue.Text = _progressBar.Value.ToString();


        //box containing all of the elements, let's say it's our cash register
        _cashBox = new System.Windows.Forms.GroupBox();
        _cashBox.BackColor = System.Drawing.SystemColors.Info;
        _cashBox.Location = new System.Drawing.Point(x, y);
        _cashBox.Name = "CashRegister";
        _cashBox.Size = new System.Drawing.Size(229, 83);
        _cashBox.TabIndex = 8;
        _cashBox.TabStop = false;
        _cashBox.Text = $"CashRegister {number}";


        //this makes that things are added to the groupbox
        _cashBox.Controls.Add(_NumberOfCustomersInTheQueue);
        _cashBox.Controls.Add(_cashState);
        _cashBox.Controls.Add(_progressBar);


        //this adds the cash register to a form
        form.Controls.Add(_cashBox);


        _opened = true;
        _id = number;

    }

    public int close() // closes the cash register
    {
        _opened = false;

        this._NumberOfCustomersInTheQueue.Invoke(
            new Action(() => this._NumberOfCustomersInTheQueue.Text = "X")
            );
        this._cashState.Invoke(
            new Action(() => this._cashState.Text = "CLOSED")
            );

        Thread.Sleep(5000); // break of the cashier

        return 1;
    }

    public int open() // opens the cash register
    {
        this._NumberOfCustomersInTheQueue.Invoke(
            new Action(() => this._NumberOfCustomersInTheQueue.Text = "0")
            );
        this._cashState.Invoke(
            new Action(() => this._cashState.Text = "customers in the queue")
            );

        _opened = true;

        return 1;
    }

    public int serve(Label CustomersLeft) // simulation of customer service
    {
        Random x = new Random();
        Thread.Sleep(x.Next(2000, 7000)); // customer service takes the time

        semaphore.WaitOne(); // these changes needs to be done separately

        this._progressBar.Invoke(
                    new Action(() => this._progressBar.Value -= 1)
                    );

        this._NumberOfCustomersInTheQueue.Invoke(
            new Action(() => this._NumberOfCustomersInTheQueue.Text = this._progressBar.Value.ToString())
            );

        lock (CustomersLeft) // decreasing the number of customers in the shop
        {
            int arg = int.Parse(CustomersLeft.Text);
            arg--;
            CustomersLeft.Invoke(
                new Action(() => CustomersLeft.Text = arg.ToString())
                );
        }

        semaphore.Release();

        // ...customer left the shop

        return 1;
    }

    public int changeCashiers() // simulates changing cashiers
    {
        this._cashState.Invoke(
            new Action(() => this._cashState.Text = "Changing Cashier...")
            );

        Thread.Sleep(2000);

        return 1;
    }

    public void work(Label CustomersLeft) // simulates the whole cash register work
    {
        Random time = new Random();

        Task.Delay(new TimeSpan(0, 0, time.Next(5, 15))).ContinueWith( // after some time, the cash is getting ready to be closed
            o =>
            {
                _opened = false;
            });

        while (isOpen) // serves until the cash state is set to open
        {
            if (!isEmpty) // ...and is not empty
            {
                serve(CustomersLeft);
            }
        }

        while (!isEmpty) // serves all customers in the queue and then closes
        {
            serve(CustomersLeft);
        }

        close();

        changeCashiers();

        open();

        work(CustomersLeft); // recursive call of this function
    }

    public int addCustomer() // adds the customer to the cash register
    {
        this._progressBar.Invoke(
                    new Action(() => this._progressBar.Value += 1)
                    );

        this._NumberOfCustomersInTheQueue.Invoke(
            new Action(() => this._NumberOfCustomersInTheQueue.Text = this._progressBar.Value.ToString())
            );

        return 1;
    }

    public void stop() // stops the simulation of the cash register
    {
        semaphore.WaitOne();
    }
}