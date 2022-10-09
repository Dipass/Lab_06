using System;

class Worker : Human
{
    private decimal _week = 0;
    private decimal _hour = 0;
    private decimal _day = 0;

    public Worker(string first, string last, decimal week, decimal day)
        : base(first, last)
    {
        Week = week;
        Day = day;
    }

    public decimal Day
    {
        get
        {
            return _day;
        }
        set
        {
            if (value < 10)
            {
                Console.WriteLine("Expected value mismatch!");
            }
            else
                _day = value;
        }
    }

    public decimal Week
    {
        get
        {
            return _week;
        }
        set
        {
            if (value < 1 || value > 12)
            {
                Console.WriteLine("Expected value mismatch! ");
            }
            _week = value;
        }
    }

    public decimal Hour
    {
        get
        {
            return _week / (_day * 5);
        }
       
    }

    public override string ToString()
    {
        return String.Format($"First Name: {First} \n" +
            $"Last Name: {Last} \n" +
            $"Week Salary: {Week}  \n" +
            $"Hours par day: {Day} \n" +
            $"Salary per hour: {Hour} \n");
    }
}