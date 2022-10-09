using System;

class Person
{
    private string Name_Person = "none";
    private int Age_Person = 0;

    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public string Name
    {
        get
        {
            return Name_Person;
        }
        set
        {
            if (value.Length < 3)
                Console.WriteLine("Name's length should not be less than 3 symbols!");
            else
                Name_Person = value;
        }
    }

    public int Age
    {
        get { return Age_Person; }
        set
        {
            if (value < 0)
                Console.WriteLine("Age must be positive! \n");
            else
                Age_Person = value;
        }
    }

    public override string ToString()
    {

        return String.Format("People: " + Name + " " + "age " + Age);
    }

}