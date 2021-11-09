using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            /*//!==================================================================================================================================================  STRINGS IN C#  ================================================================*/

            //  string greet = "Hello,Good Morning";
            //  Console.WriteLine(greet);

            //? STRING METHODS
            // //* 1.Length
            // Console.WriteLine(greet.Length);
            // //* 2.upper,lower
            // Console.WriteLine(greet.ToUpper());
            // Console.WriteLine(greet.ToLower());
            // //*3.string.concat
            // Console.WriteLine(string.Concat(greet,",How Are You?"));

            //! String Interpulation
            // Console.WriteLine("Enter Your Name : ");
            // string name = Console.ReadLine();
            // Console.WriteLine("Enter Your Age : ");
            // string candies = Console.ReadLine();
            // Console.WriteLine($"Your name is {name} and you will get {candies} candies");

            //Indexing in C#
            // string greet = "Hello,Good Morning";
            // Console.WriteLine(greet[0]);
            // Console.WriteLine(greet.IndexOf("Morning"));
            // Console.WriteLine(greet.Substring(6));

            /*//!=============================================================================================================================================  CONDITIONALS IN C#  ================================================================*/

            // Console.Write("Enter Your Age : ");
            // string ageNum = Console.ReadLine();
            // int age = Convert.ToInt32(ageNum);

            // if (ageNum >= 18)
            // {
            //     Console.WriteLine("You Can Drive");
            // }
            // else if (ageNum < 2)
            // {
            //     Console.WriteLine("You are just born");
            // }
            // else
            // {
            //     Console.WriteLine("You Can't Drive");
            // }

            /*//!===================================================================================================================================================  SWITCH IN C#  ================================================================*/

            // int age = 32;
            // switch (age){
            //     case 18:
            //         Console.WriteLine("Please wait for an year");
            //         break;
            //     case 20:
            //         Console.WriteLine("You are 20");
            //         break;
            //     default:
            //         Console.WriteLine("Enjoy!");
            //         break;
            // }

            /*//!======================================================================================================================================================= LOOPS IN C#  ==============================================================*/

            // ?Types in Loops --> while,do-while,for
            // ?1.While Loop

            // int i = 0;
            // while (i<=50)
            // {
            //      Console.WriteLine(i);
            //      i++;
            // }

            //?2.Do-While loops
            // do
            // {
            //     Console.WriteLine(i);
            //     i++;
            // } while (i<500);

            //? 3.For Loops
            for (int j = 0; j < 21; j++)
            {
                Console.WriteLine(j);
            }
            Console.ReadLine();
        }
    }
}
