using System;

internal class Laptop
{
    private string model;
    private string manufacturer;
    private string processor;
    private string ram;
    private string graphicsCard;
    private string hdd;
    private string screen;
    private Battery battery;
    private decimal price;

    public string Model
    {
        get { return this.model; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException(Model);
            }
            else
            {
                this.model = value;
            }
        }
    }

    public string Manufacturer
    {
        get { return this.manufacturer; }
        set
        {
            if (value != null && value.Length < 1)
            {
                throw new ArgumentNullException(Manufacturer);
            }
            else
            {
                this.manufacturer = value;
            }
        }
    }

    public string Processor
    {
        get { return this.processor; }
        set
        {
            if (value != null && value.Length < 1)
            {
                throw new ArgumentNullException(processor);
            }
            else
            {
                this.processor = value;
            }
        }
    }

    public string RAM
    {
        get { return this.ram; }
        set
        {
            if (value != null && value.Length < 1)
            {
                throw new ArgumentNullException(ram);
            }
            else
            {
                this.ram = value;
            }
        }
    }

    public string GraphicsCard
    {
        get { return this.graphicsCard; }
        set
        {
            if (value != null && value.Length < 1)
            {
                throw new ArgumentNullException(graphicsCard);
            }
            else
            {
                this.graphicsCard = value;
            }
        }
    }

    public string HDD
    {
        get { return this.hdd; }
        set
        {
            if (value != null && value.Length < 1)
            {
                throw new ArgumentNullException(hdd);
            }
            else
            {
                this.hdd = value;
            }
        }
    }

    public string Screen
    {
        get { return this.screen; }
        set
        {
            if (value != null && value.Length < 1)
            {
                throw new ArgumentNullException(screen);
            }
            else
            {
                this.screen = value;
            }
        }
    }

    public decimal Price
    {
        get { return this.price; }
        set
        {
            if (value < 1m)
            {
                throw new ArgumentNullException("Price");
            }
            else
            {
                this.price = value;
            }
        }
    }

    public Battery Battery
    {
        get { return this.battery; }
        set { this.battery = value; }
    }

    public Laptop(string model, decimal price,
        string manufacturer = null, string processor = null, string ram = null,
        string graphicsCard = null, string hdd = null, string screen = null, Battery battery = null)
    {
        this.Model = model;
        this.Price = price;
        this.Manufacturer = manufacturer;
        this.Processor = processor;
        this.RAM = ram;
        this.GraphicsCard = graphicsCard;
        this.HDD = hdd;
        this.Screen = screen;
        this.Battery = battery;
    }

    public override string ToString()
    {
        string result = string.Format(
            "Laptop - Model: {0}, Manufacturer: {1}, Processor: {2}," +
            " RAM: {3}, Graphics Cards: {4}, HDD: {5}," +
            " Screen size: {6}, Battery: {7}, Price: {8} lv.",
            this.Model, this.Manufacturer, this.Processor,
            this.RAM, this.GraphicsCard, this.hdd,
            this.screen, this.battery, this.price);
        return result;
    }
}