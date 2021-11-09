using System;

namespace tut
{
    class Program
    {
        static void Main(string[] args)
        {
            /*//!=======================================================================================================================================================  BASE IN C# =================================================================*/
            // Console.WriteLine("Hello World!");
            // string a = "Soham";
            // int b = 5;
            // int c = 4;
            // Console.WriteLine(a);
            // Console.WriteLine(b+c);

            // for (int i = 0; i <= 10; i++)   
            // {
            //     Console.Write(i);
            //     Console.Write(',');

            // }


            // Console.ReadLine();


            /* //!=================================================================================================================== ============================== DATATYPES IN C# ===============================================================*/

            // Console.WriteLine("DataTypes In C#");
            /*
            DataTypes In C#
            1.int --> 4bytes
            2.string --> 2bytes/char
            3.float --> 4bytes
            4.char --> 2bytes
            5.bool --> 1bit
            6.long --> 8bytes
            7.double --> 8bytes
            */

            // taking input in c#
            // Console.Write("Enter The Number : ");
            // string inp = Console.ReadLine();
            // Console.WriteLine("The number is : " + inp);

            // double ny = 45.12;
            // Console.WriteLine(ny);


            //DATATYPES EXAMPLE

            // int a = 5;
            // float b = 45.2F;
            // double c = 4525.56D;
            // long d = 51321321;
            // char e = 'e';
            // string f = "Hello";
            // bool g = false;

            // Console.WriteLine(a);
            // Console.WriteLine(b);
            // Console.WriteLine(c);
            // Console.WriteLine(d);
            // Console.WriteLine(e);
            // Console.WriteLine(f);
            // Console.WriteLine(g);

            // Console.ReadLine();
            // !==================================================================================================================
            //! =============================== TYPECASTING IN C# ===============================================================

            // int a = (int)45.95;
            // float b = (float)23;

            // Console.WriteLine(a);
            // Console.WriteLine(b);

            /*THERE ARE TWO TYPES OF CASTING IN C#
            1.IMPLICIT CASTING
            char --> int --> long --> float --> double
            int x = 3;
            int y = x;
            */
            // int x = 3;
            // int y = x;

            // Console.WriteLine(x);
            // Console.WriteLine(y);


            /*2.EXPLICIT CASTING*/

            /*  int x = (int)45.121;
              Console.WriteLine(x);
            */

            /*3.ANOTHER WAY OF TYPECASTING*/
            // float var = Convert.ToInt32(3.55);  
            // Console.WriteLine(var);
            // string x = "34 is nice";
            // float y = 34.4F;
            // Convert.ToDouble;
            // Convert.ToString;
            // Convert.ToBoolean;

            // Console.Write("Enter Your Name : ");
            // string name = Console.ReadLine();
            // Console.WriteLine("Hey! Hello," + name);


            // Console.Write("How Many Candies Do You Want : ");
            // string can = Console.ReadLine();
            // Console.WriteLine("You will get 4 more candies thus you will get " + (Convert.ToInt32(can) + 4) + " candies");

            /*//!==================================================================================================================================================  OPERATORS IN C# ===============================================================*/

            /*
            ? 1.Arithmetic Operators ==> +,-,*,/
            ? 2.Assignment Operators ==> =
            ? 3.Logical Operators    ==> |,&
            ? 4.Comparision Operators==> <,>,<=,=>
            */

            //** 1.Arithmetic Operators
            // float a = 4;
            // float b = 6;
            // Console.WriteLine("a+b = " + (a+b));
            // Console.WriteLine("a-b = " + (a-b));
            // Console.WriteLine("a*b = " + (a*b));
            // Console.WriteLine("a/b = " + (a/b));

            //**2.Assignment Operators
            // int a =4;
            // int b = a;
            // Console.WriteLine(b);
            // b += 4;
            // Console.WriteLine(b);
            // b -= 4;
            // Console.WriteLine(b);
            // b *= 4;
            // Console.WriteLine(b);
            // b /= 4;
            // Console.WriteLine(b);

            //**3.Logical Operators --> &&,||,!
            // Console.WriteLine(true && false);
            // Console.WriteLine(false && false);
            // Console.WriteLine(!true);
            // Console.WriteLine(!false);

            //**4.Comparision Operators --> <,>,=<,>=
            // Console.WriteLine(354>612);
            // Console.WriteLine(354<612);
            // Console.WriteLine(354>=612);
            // Console.WriteLine(354<=612);
            // Console.WriteLine(5==5);

            /*//!======================================================================================================================================================  MATH CLASS ================================================================*/

            // int a = Math.Max(34,153);
            // int a = Math.Min(34,153);    
            // double a = Math.Sqrt(1024);
            // double a = Math.Abs(-121.12);
            double a = Math.Abs(-121.12);
            Console.WriteLine(a);   

            Console.ReadLine();

        }
    }
}
