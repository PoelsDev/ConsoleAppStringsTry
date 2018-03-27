using System;

namespace ConsoleAppStringsTry
{
    class Program
    {
        static void Main(string[] args)
        {
            //string string1 = "mississippi";
            //int n = string1.IndexOf("is", 3);
            //string string2 = string1.Substring(4, 2);
            //Console.WriteLine(string2);

            string name = "Bob";
            DateTime hours = new DateTime(2011, 3, 12);
            TimeSpan alive = DateTime.Now - hours;
            Console.WriteLine($"Name = {name}, total days alive = {Math.Ceiling(alive.TotalDays)}");

        }
    }
}
