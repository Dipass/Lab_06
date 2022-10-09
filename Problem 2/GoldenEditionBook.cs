using System;
using System.Collections.Generic;
using System.Text;

class GoldenEditionBook : Book
{

    public GoldenEditionBook(string book, string who, decimal price)
        : base(book, who, price)
    {
        Price = price;
    }

    public override decimal Price
    {
        get
        {
            return base.Price * 1.3m;
        }

    }
    public override string ToString()
    {
        return String.Format($"Type: GoldenEditionBook \n" +
            $"Title: {Title} \n" +
            $"Autor: {Autor} \n" +
            $"Price: {Price} \n");
    }
}