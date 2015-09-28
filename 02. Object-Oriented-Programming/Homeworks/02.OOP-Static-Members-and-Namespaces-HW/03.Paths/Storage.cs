using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using _01.Point3D;

namespace _03.Paths
{
    static class Storage
    {
        public static void SavePathToFile(string filePath, string path)
        {
            StreamWriter writen = new StreamWriter(filePath,false, Encoding.GetEncoding("UTF-8"));
            using (writen)
            {
                writen.WriteLine(path);
            }
        }

        public static Path3D LoadPathFromFile(string filePath)
        {
            Path3D path = new Path3D();
            const string pointPattern = @"[xyz=:\-\s](\d+(?:(?:\.|,)\d+)*)";
            StreamReader reader = new StreamReader(filePath);
            using (reader)
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    MatchCollection matches = Regex.Matches(line, pointPattern);
                    if (matches.Count == 3)
                    {
                        double x = double.Parse(matches[0].Groups[1].Value);
                        double y = double.Parse(matches[1].Groups[1].Value);
                        double z = double.Parse(matches[2].Groups[1].Value);

                        Point3D point = new Point3D(x, y, z);
                        path.AddPoint(point);
                    }

                    line = reader.ReadLine();
                }

            }
            return path;
        }
    }
}
