using System;
using System.Collections.Generic;
using System.Linq;

internal class PC_Catalogue
{
    private static void Main()
    {
        List<Computer> computers = new List<Computer>();

        Computer PC1 = new Computer(
                name: "ASUS",
                motherboard: new Component("Asus AK-47", 334m, "mini form factor"),
                processor: new Component("i7 2345", 234m, "64 cores"),
                ram: new Component("32GB", 200m, "DDR5"));

        Computer PC2 = new Computer(
            name: "GigaBUUUG",
            motherboard: new Component("Gigabyte AZ32", 144m, "mini form factor"),
            processor: new Component("i5 2345", 134m, "32 cores"),
            ram: new Component("16GB", 100m, "DDR5"));

        Computer PC3 = new Computer(
            name: "Handmade",
            motherboard: new Component("Marmalad duno", 112m),
            processor: new Component("i3 2200", 104m),
            ram: new Component("8GB", 80m));

        computers.Add(PC1);
        computers.Add(PC2);
        computers.Add(PC3);

        computers = computers.OrderBy(o => o.totalPrice).ToList();

        foreach (var computer in computers)
        {
            Console.WriteLine(computer);
            Console.WriteLine();
        }
    }
}