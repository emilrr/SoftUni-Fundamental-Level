using System;

class Person
{
    private string name;
    private int age;
    private string email;

    public Person(string name, int age, string email)
    {
        this.Name = name;
        this.Age = age;
        this.Email = email;
    }

    public Person(string name, int age) : this(name, age, null)
    {
        this.Name = name;
        this.Age = age;
        this.Email = email;
    }

    public string Name
    {
        get { return this.name; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Name cannot be empty!");
            }
            this.name = value;
        }
    }

    public int Age
    {
        get { return this.age; }
        set
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentException("Invalid age! It should be in the range [0...100].");
            }
            this.age = value;
        }
    }

    public string Email
    {
        get { return this.email; }
        set
        {
            if (value != null && !value.Contains("@"))
            {
                throw new ArgumentException("Your email is not valid!");
            }
            this.email = value;
        }
    }

    public override string ToString()
    {
        return string.Format("Hi! My name is {0}, I am {1} years old ", this.Name, this.Age)
               + (this.Email == null ? "and I do not have an email!" : "email: " + this.Email);
    }
}

