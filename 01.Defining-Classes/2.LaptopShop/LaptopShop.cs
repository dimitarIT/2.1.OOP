using System;

internal class LaptopShop
{
    private static void Main()
    {
        Laptop LenovoY50 = new Laptop(
            model: "Lenovo Y50",
            manufacturer: "Lenovo",
            price: 2665.0m,
            processor: "Intel Core i7-4710MQ (4-ядрен, 2.50 - 3.50 GHz, 6MB кеш)",
            ram: "8 GD",
            graphicsCard: "NVIDIA GeForce GTX 860M (4GB GDDR5, GM107)",
            hdd: "128GB SSD", screen: "15.6-инчов (39.62 см.) - 1920x1080 (Full HD), матов",
            battery: new Battery(lifeInHours: 4.5f, description: "6-клетъчна")
            );

        Laptop LenovoYoga2Pro = new Laptop(
            model: "Lenovo Yoga 2 Pro",
            price: 699.00m
            );

        Console.WriteLine(LenovoY50);
        Console.WriteLine();
        Console.WriteLine(LenovoYoga2Pro);
    }
}