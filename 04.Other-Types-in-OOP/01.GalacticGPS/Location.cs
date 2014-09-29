public struct Location
{
    private double latitude;

    private double longtitude;

    private Planet planet;

    public Location(double latitude, double longtitude, Planet planet)
        : this()
    {
        this.Latitude = latitude;
        this.Longtitude = longtitude;
        this.Planet = planet;
    }

    public double Latitude
    {
        get
        {
            return this.latitude;
        }
        set
        {
            this.latitude = value;
        }
    }

    public double Longtitude
    {
        get
        {
            return this.longtitude;
        }
        set
        {
            this.longtitude = value;
        }
    }

    public Planet Planet
    {
        get
        {
            return this.planet;
        }
        set
        {
            this.planet = value;
        }
    }

    public override string ToString()
    {
        return string.Format("{0}, {1} - {2}", this.Latitude, this.Longtitude, this.Planet);
    }
}