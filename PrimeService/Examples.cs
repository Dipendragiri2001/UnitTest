using System;

namespace PrimeService
{
    public class Examples
    {
        public static string ExampleLoadTextFile(string file)
        {
            if (file.Length < 10)
            {
                throw new ArgumentException("The file name was too short", "file");
            }
            return "The file was correctly loaded";
        }
    }
}