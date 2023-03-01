namespace supermarket;

using System;
using System.Windows.Forms;
using System.Threading;


public class customer
{
    private int _id;

    public customer(int arg) //constructs the customer
    {
        _id = arg;
    }

    public int shopping() // customer is shopping for x amount of time
    {
        Random x = new Random();
        //return x.Next(3000, 10000); //3sec to 10 sec
        return x.Next(3, 10); //3sec to 10 sec
    }

}