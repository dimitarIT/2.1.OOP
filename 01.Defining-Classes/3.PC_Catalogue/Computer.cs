using System;

internal class Computer
{
    private string name;
    private Component motherboard;
    private Component processor;
    private Component ram;

    public string Name
    {
        get { return this.name; }
        set
        {
            ValidationOfComponent.IsStringEmpty(value, "Computer name ");
            this.name = value;
        }
    }

    public Component Motherboard
    {
        get { return this.motherboard; }
        set { this.motherboard = value; }
    }

    public Component Processor
    {
        get { return this.processor; }
        set { this.processor = value; }
    }

    public Component Ram
    {
        get { return this.ram; }
        set { this.ram = value; }
    }

    public decimal totalPrice
    {
        get
        {
            return this.Motherboard.Price + this.Processor.Price + this.Ram.Price;
        }
    }

    public Computer(string name, Component motherboard, Component processor, Component ram)
    {
        this.name = name;
        this.Motherboard = motherboard;
        this.Processor = processor;
        this.Ram = ram;
    }

    public override string ToString()
    {
        string result = "";
        string name = this.name;
        string motherboardName = this.Motherboard.Name + " " + this.motherboard.Details;
        string motherboardPrice = Convert.ToString(this.Motherboard.Price);
        string processorName = this.Processor.Name + " " + this.Processor.Details;
        string processorPrice = Convert.ToString(this.Processor.Price);
        string ramName = this.Ram.Name + " " + this.Ram.Details;
        string ramPrice = Convert.ToString(this.Ram.Price);

        result = String.Format("Computer Name: {0}\n Motherboard: {1} Price: {2} лв.\n Processor: {3} Price: {4} лв.\n Ram: {5} Price: {6}лв.\n Total price: {7} лв. ",
            name, motherboardName, motherboardPrice, processorName, processorPrice, ramName, ramPrice, totalPrice);

        return result;
    }
}