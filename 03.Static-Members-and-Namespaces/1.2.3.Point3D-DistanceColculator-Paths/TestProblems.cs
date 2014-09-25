using System;

internal class TestProblems
{
    private static void Main()
    {
        Console.WriteLine("Problem 1. Point3D");
        Point3D p1 = new Point3D(1, 2, 3);
        Point3D p2 = new Point3D(3.4, 4.66, 5.55);

        Console.WriteLine(p1);
        Console.WriteLine(p2);
        Console.WriteLine(Point3D.StartPoint);
        Console.WriteLine();

        Console.WriteLine("Problem 2. Distance Calculator");
        double distance = DistanceCalculator.CalculateDistance(p1, p2);
        Console.WriteLine(distance);
        Console.WriteLine();

        Console.WriteLine("Problem 3. Paths3D");
        Path3D path = new Path3D(p1, p2, Point3D.StartPoint);
        Console.WriteLine("Save path: {0}", path);
        Storage.SavePathInFile("path.txt", path);
        Path3D loadPath = Storage.LoadPathOfFile("path.txt");
        Console.WriteLine("Load path: {0}", loadPath);
    }
}