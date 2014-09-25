using System;
using System.IO;
using System.Text.RegularExpressions;

internal class Storage
{
    public static void SavePathInFile(string fileName, Path3D path)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            writer.Write(path);
        }
    }

    public static Path3D LoadPathOfFile(string fileName)
    {
        Path3D path = new Path3D();

        using (StreamReader reader = new StreamReader(fileName))
        {
            string input = reader.ReadToEnd();

            string pattern = "{([\\d,.]+), ([\\d,.]+), ([\\d,.]+)}";

            var reg = new Regex(pattern);
            var matches = reg.Matches(input);

            if (matches.Count <= 0)
            {
                throw new ApplicationException("Invalid data in file " + fileName);
            }

            foreach (Match match in matches)
            {
                double x = double.Parse(match.Groups[1].Value);
                double y = double.Parse(match.Groups[2].Value);
                double z = double.Parse(match.Groups[3].Value);

                Point3D p = new Point3D(x, y, z);
                path.AddPoint(p);
            }
        }

        return path;
    }
}