using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Value Types
            //Console.WriteLine("Hello World!");

            double number5 = 10.4; // floating point
            decimal number6 = 10.5m; // floating point
            char character = 'A'; // a character UTF-16
            bool condition = true; // true or false
            byte number4 = 255; // 8 bit unsigned
            short number3 = 32767; // 16 bit signed
            int number1 = 2147483647; // 32 bit signed
            long number2 = 9223372036854775807; // 64 bit signed
            var number7 = 10;
            number7 = 'A';
            // number7 = "A"; // don't work

            Console.WriteLine("Number1 is {0}",number1);
            Console.WriteLine("Number2 is {0}", number2);
            Console.WriteLine("Number3 is {0}", number3);
            Console.WriteLine("Number4 is {0}", number4);
            Console.WriteLine("Number5 is {0}", number5);
            Console.WriteLine("Number6 is {0}", number6);
            Console.WriteLine("Number7 is {0}", number7);

            Console.WriteLine("Condition is : {0}", condition);
            Console.WriteLine("Character is : {0}", character);
            Console.WriteLine("Character is : {0}", (int)character); // ASCII character

            Console.WriteLine(Days.Friday);
            Console.WriteLine((int)Days.Friday); // sequence number in the list

            Console.ReadLine();
        }
    }

    enum Days
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }
}