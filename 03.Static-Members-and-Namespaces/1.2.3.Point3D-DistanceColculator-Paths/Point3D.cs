using System;

public class Point3D
{
    private double PointX;
    private double PointY;
    private double PointZ;
    internal static readonly Point3D StartPoint;

    public Point3D(double x, double y, double z)
    {
        this.PointX = x;
        this.PointY = y;
        this.PointZ = z;
    }

    static Point3D()
    {
        Point3D.StartPoint = new Point3D(0, 0, 0);
    }

    public double X
    {
        get
        {
            return this.PointX;
        }
    }

    public double Y
    {
        get
        {
            return this.PointY;
        }
    }

    public double Z
    {
        get
        {
            return this.PointZ;
        }
    }

    public static Point3D startPoint3D
    {
        get
        {
            return StartPoint;
        }
    }

    public override string ToString()
    {
        string result = "{";
        result += String.Format("{0}, {1}, {2}", this.X, this.Y, this.Z);
        result += "}";
        return result;
    }
}