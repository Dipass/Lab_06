using System;
class Student : Human
{
    private string Facultet_number = "none";
    public Student(string first, string last, string number)
        : base(first, last)
    {
        Number = number;
    }

    public string Number
    {
        get
        {
            return Facultet_number;
        }
        set
        {
            if (value.Length < 5 || value.Length > 10)
            {
                Console.WriteLine("Invalid faculty number!");
            }
            else
                Facultet_number = value;
        }
    }

    public override string ToString()
    {
        return String.Format($"First Name {First} \n" +
            $"Last Name {Last} \n" +
            $"Factualy number {Number}\n");
    }

}