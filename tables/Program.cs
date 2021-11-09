using System;

namespace tables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculate Any Table");

            Console.Write("Enter The Number : ");
            string num = Console.ReadLine();

            for (int i = 1; i < 11; i++)
            {
               Console.WriteLine(Convert.ToInt64(num) +  " X " + i + " = " + (Convert.ToInt64(num)*i));
            }
        }
    }
}
