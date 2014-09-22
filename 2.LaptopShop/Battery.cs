using System;

public class Battery
{
    private string description;
    private float lifeInHours;

    public Battery(float lifeInHours, string description = null)
    {
        this.LifeInHours = lifeInHours;
        this.Description = description;
    }

    public string Description
    {
        get { return this.description; }
        set
        {
            if (value != null && value.Length < 1)
            {
                throw new ArgumentNullException(Description);
            }
            else
            {
                this.description = value;
            }
        }
    }

    public float LifeInHours
    {
        get { return this.lifeInHours; }
        set
        {
            if (value < 1f)
            {
                throw new ArgumentNullException("LifeInHours");
            }
            else
            {
                this.lifeInHours = value;
            }
        }
    }

    public override string ToString()
    {
        string result = string.Format
            ("{0}, Battery life in hours: {1}",
            this.Description, this.LifeInHours);
        return result;
    }
}