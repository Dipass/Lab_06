using System;
class Human
{
    private string First_Name = "None";
    private string Last_Name = "None";

    public Human(string first, string last)
    {
        First = first;
        Last = last;
    }

    public string First
    {
        get
        {
            return First_Name;
        }
        set
        {
            if (value.Length < 3 || string.IsNullOrEmpty(value))
                Console.WriteLine("Expected length at least 4 symbols!");
            if (Char.IsLower(value, 0))
            {
                Console.WriteLine("Expected upper case letter!");
            }
            else
                First_Name = value;
        }
    }

    public string Last
    {
        get
        {
            return Last_Name;
        }
        set
        {
            if (value.Length < 2 || string.IsNullOrEmpty(value))
                Console.WriteLine("Expected length at least 3 symbols!");
            if (Char.IsLower(value, 0))
            {
                Console.WriteLine("Expected upper case letter!");
            }
            else
                Last_Name = value;
        }
    }
}