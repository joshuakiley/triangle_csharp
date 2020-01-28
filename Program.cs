using System;

namespace triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the file name excluding the file extension:");

            string fileName = Console.ReadLine();

            string strData = System.IO.File.ReadAllText($"./data/{fileName}.txt");

            string[] data = strData.Split(
                new[] { "\r\n", "\r", "\n" },
                StringSplitOptions.None
            );

            try
            {
                int m = Int32.Parse(data[0]);
                Console.WriteLine(m + m);

            }
            catch (FormatException err)
            {
                Console.WriteLine($"Error: {err.Message}");
            }



        }
    }
}
