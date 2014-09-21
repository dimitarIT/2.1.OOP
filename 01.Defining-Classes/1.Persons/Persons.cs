using System;

internal class Persons
{
    private static void Main()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        Console.Write("Please enter your age: ");
        byte age = byte.Parse(Console.ReadLine());
        Console.Write("Please enter your email: ");
        string email = Console.ReadLine();

        Person somePerson = new Person(name, age, email);

        Console.WriteLine(somePerson);
    }
}