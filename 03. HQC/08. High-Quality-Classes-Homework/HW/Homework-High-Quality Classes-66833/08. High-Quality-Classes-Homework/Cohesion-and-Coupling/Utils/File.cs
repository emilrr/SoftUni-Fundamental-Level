namespace CohesionAndCoupling.Utils
{
    using System;

    public static class File
    {
        public static string GetExtension(string fileName)
        {
            int indexOfLastDot = fileName.LastIndexOf(".", StringComparison.Ordinal);
            if (indexOfLastDot == -1)
            {
                return string.Empty;
            }

            string extension = fileName.Substring(indexOfLastDot + 1);
            return extension;
        }

        public static string GetNameWithoutExtension(string fileName)
        {
            int indexOfLastDot = fileName.LastIndexOf(".", StringComparison.Ordinal);
            if (indexOfLastDot == -1)
            {
                return fileName;
            }

            string extension = fileName.Substring(0, indexOfLastDot);
            return extension;
        }
    }
}