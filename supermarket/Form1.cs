namespace supermarket;

using System.Threading;
using System.Media;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;


public partial class form : Form
{
    List<cash_register> cashes = new List<cash_register>();
    List<customer> customers = new List<customer>();

    SemaphoreSlim sem = new SemaphoreSlim(0, 1);
    bool control = false;

    int NoOfCashes = 0;      // M- no. of cash registers
    int NoOfCustomers = 0;   // N- no. of customers


    public form()
    {
        InitializeComponent();
    }

    public static void sound()
    {
        string rootLocation = typeof(Program).Assembly.Location;
        string fullPathToSound = Path.Combine(rootLocation, @"..\..\..\..\..\..\kolekcja_klasyki.wav");
        SoundPlayer sound = new SoundPlayer();
        sound.SoundLocation = fullPathToSound;
        sound.Play();
        Thread.Sleep(8 * 1000);
    }

    private void initialize() //initializes the form
    {

        //x=188 y=12

        NoOfCashes = (int)M.Value;
        NoOfCustomers = (int)N.Value;

        int x = 188, y = 12;

        for (int i = 0; i < NoOfCashes; i++) //initialize cashes
        {
            cash_register cash = new cash_register(this, x, y, i + 1);
            cashes.Add(cash);
            y += 100;
        }

        this.CustomersLeft.Text = $"{NoOfCustomers}";

        for (int i = 0; i < NoOfCustomers; i++) //initialize customers
        {
            customer customer = new customer(i);
            customers.Add(customer);
        }

    }

    public void assignCustomer(customer customer) //assigns the customer to the cash register
    {

        int choice;
        bool assigned = false;
        Random x;

        while (!assigned) //loop until the customer will be assigned
        {
            x = new Random();
            choice = x.Next(0, NoOfCashes);

            cashes[choice].semaphore.WaitOne();

            if (cashes[choice].isOpen && !(cashes[choice].isFull)) //if the cash register is not full and is open
            {

                cashes[choice].addCustomer(); //adding customer to the cash register

                assigned = true;

                customers.Remove(customer);

            }

            cashes[choice].semaphore.Release();

        }

    }


    private void RemoveAllCashes() //function removes cash registers and sets the form to it's default state
    {

        cashes.ForEach(cash =>
        {
            Controls.Remove(cash.CashBox);
            cash.Dispose();
        });

        cashes.Clear();

    }
    private void RemoveAllCustomers() //function removes all customers
    {

        customers.Clear();

        this.CustomersLeft.Text = "X";

    }
    private void simulation() // starts the simulation
    {

        cashes.ForEach(cash => // cashes start their work
        {
            Thread thread = new Thread(() => cash.work(CustomersLeft));
            thread.IsBackground = true;
            thread.Start();
        });

        Parallel.ForEach(customers, c => // customers are starting shopping
        {

            Task.Delay(new TimeSpan(0, 0, c.shopping())).ContinueWith( // after some time for shopping
            o =>
            {
                if (control)
                {
                    assignCustomer(c); // ..assign customer

                }

            });


        });

    }
    private void start_Click(object sender, EventArgs e) //when start button is clicked
    {

        control = true;

        //Thread t1 = new Thread(sound);
        //t1.IsBackground = true;
        //if (t1.IsAlive) { t1.Interrupt(); }
        //t1.Start();

        RemoveAllCashes();

        RemoveAllCustomers();

        initialize();

        simulation();
    }

    private void stop_Click(object sender, EventArgs e) //when stop button is clicked
    {

        if (control)
        {
            cashes.ForEach(cash =>
            {
                cash.stop(); //stop all of the cashes
            });
        }

        control = false;

    }

}
