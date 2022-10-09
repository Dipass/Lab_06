using System;

class Child : Person
{
    private int Age_Child = 0;
    public Child(string name, int age)
        : base(name, age)
    {
        Age = age;

    }

    public int Age
    {
        get
        {
            return Age_Child;
        }
        set
        {
            if (value > 15 || value < 0)
                Console.WriteLine("Child's age must be less than 15! \n");
            else
                Age_Child = value;
        }
    }
    public override string ToString()
    {
        return String.Format("Child: " + Name + " " + "age " + Age);
    }
}