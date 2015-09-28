using System;
using System.Runtime.CompilerServices;

class Component
{
    private string name;
    private decimal price;

    public Component(string name, decimal price)
    {
        this.Name = name;
        this.Price = price;
    }

    public Component(string name, decimal price, string details)
        : this(name, price)
    {
        this.Details = details;
    }

    public string Name
    {
        get { return this.name; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Name cannot be emprty");
            }
            this.name = value;
        }
    }

    public decimal Price
    {
        get { return this.price; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Price cannot be negative!");
            }
            this.price = value;
        }
    }

    public string Details { get; set; }


}

