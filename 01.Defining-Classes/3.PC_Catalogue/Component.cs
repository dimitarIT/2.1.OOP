internal class Component
{
    private string name;
    private string details;
    private decimal price;

    public string Name
    {
        get { return this.name; }
        set
        {
            ValidationOfComponent.IsStringEmpty(value, "Part name");
            this.name = value;
        }
    }

    public decimal Price
    {
        get { return this.price; }
        set
        {
            ValidationOfComponent.IsNumberNegative(value, "Price");
            this.price = value;
        }
    }

    public string Details
    {
        get { return this.details; }
        set
        {
            ValidationOfComponent.IsStringEmpty(value, "Details");
            this.details = value;
        }
    }

    public Component(string name, decimal price)
    {
        this.Name = name;
        this.Price = price;
    }

    public Component(string name, decimal price, string details = null)
    {
        this.Name = name;
        this.Details = details;
        this.Price = price;
    }
}