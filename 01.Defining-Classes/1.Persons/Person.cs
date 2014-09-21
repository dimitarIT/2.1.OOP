using System;

internal class Person
{
    private string name;
    private int age;
    private string email;

    public string Name
    {
        get { return this.name; }
        set
        {
            while (string.IsNullOrEmpty(value))
            {
                Console.Write("\"Name\" Cannot be empty, please enter your name: ");
                value = Console.ReadLine();
            }
            this.name = value;
        }
    }

    public int Age
    {
        get { return this.age; }
        set
        {
            while (value < 8 || value > 100)
            {
                Console.Write("\"Age\" Should be in range [8...100], please enter your age: ");
                value = int.Parse(Console.ReadLine());
            }
            this.age = value;
        }
    }

    public string Email
    {
        get { return this.email; }

        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                while (value != null && !value.Contains("@"))
                {
                    Console.Write("\"Email\" incorrect format, please enter your email: ");
                    value = Console.ReadLine();
                }
                this.email = "\nemail " + value;
            }
            else
            {
                this.email = "\nemail - no email";
            }
        }
    }

    public Person(string name, int age, string email)
    {
        this.Name = name;
        this.Age = age;
        this.Email = email;
    }

    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
        this.Email = email;
    }

    public override string ToString()
    {
        string result = string.Format("Person:\nName - {0}\nAge - {1}{2}", name, age, email);
        return result;
    }
}