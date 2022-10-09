using System;

class Book
{
    private string _autor = "None";
    private string _title = "None";
    private decimal _price = 0;

    public Book(string book, string who, decimal price)
    {
        Title = book;
        Autor = who;
        Price = price;
    }
    public string Title
    {
        get { return _title; }
        set
        {
            if ((value.Length < 3))
                Console.WriteLine("Name's length should not be less than 3 symbols!");
            else
                _title = value;
        }
    }

    public string Autor
    {
        get { return _autor; }
        set
        {
            if (value.Length < 3)
                Console.WriteLine("Name's length should not be less than 3 symbols!");
            else
                _autor = value;
        }
    }

    public virtual decimal Price
    {
        get { return _price; }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Price can't be zero");
            }
            else
                _price = value;
        }
    }

    public override string ToString()
    {
        return String.Format($" Type: Boke \n" +
            $" Title: {Title} \n" +
            $" Autor: {Autor} \n" +
            $" Price: {Price} \n");
    }

}