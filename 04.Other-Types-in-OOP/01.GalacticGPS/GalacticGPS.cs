using System;

internal class GalacticGPS
{
    private static void Main()
    {
        Location home = new Location(18.037986, 28.870097, Planet.Earth);
        Console.WriteLine(home);
        Location mars = new Location(20, -160.8999, Planet.Mars);
        Console.WriteLine(mars);
    }
}