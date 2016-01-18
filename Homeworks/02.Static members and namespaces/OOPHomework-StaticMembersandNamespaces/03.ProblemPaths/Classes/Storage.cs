using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using _01.ProblemPoint3D.Classes;

namespace _03.ProblemPaths.Classes
{
    static class Storage
    {

        public static void WritePathsToFile(String filePath, Path3D path)
        {
            if (filePath == null)
            {
                throw new ArgumentNullException("file path can't be null. Can't write file");
            }

            if (path == null)
            {
                throw new ArgumentNullException("path object can't be null. Can't write to file");
            }

            StringBuilder bld = new StringBuilder();
            for (int i = 0; i < path.GetNumberOfPoints(); i++)
            {
                Point3D point = path.GetPointAtIndex(i);
                bld.Append(String.Format("{0}", String.Join(", ", point.CurrentPosition)));
            }

            File.WriteAllText(filePath, bld.ToString());
        }

        public static Path3D ReadPathsFromFile(String filePath)
        {
            return ReadPathsFromFile(filePath, new Path3D());
        }

        public static Path3D ReadPathsFromFile(String filePath, Path3D path)
        {
            if (filePath == null)
            {
                throw new ArgumentNullException("File Path can't be null. Can't read file");
            }

            if (path == null)
            {
                throw new ArgumentNullException("Path Object can't be null.");
            }

            FileStream file = File.Open(filePath, FileMode.Open, FileAccess.Read);

            String pattern = @"([0-9]([,\s]+)[0-9]([,\s]+)[0-9])";
            Regex rex = new Regex(pattern);
            Match match = rex.Match(File.ReadAllText(filePath));

            while (match.Success)
            {
                String res = match.Value;
                res = Regex.Replace(res, ",", String.Empty);
                int[] arr = res.Split(' ').Select(int.Parse).ToArray();

                Point3D point = new Point3D(arr);

                path.AddPoint(point);

                match = match.NextMatch();
            }

            return path;
        }
    }
}
