using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Add();

            //var result = Add2(20,25);
            //Console.WriteLine(result);

            //var result2 = Add3(20);
            //Console.WriteLine(result2);

            //int number1 = 20;
            //Console.WriteLine("Number1 is : {0}", number1);
            //int number2 = 100;
            //var result3 = Add4(ref number1, number2);
            //Console.WriteLine(result3);
            //Console.WriteLine("ref Number1 is : {0}", number1);

            Console.WriteLine(Multiply(2, 4));
            Console.WriteLine(Multiply(2, 4, 5));

            Console.WriteLine(Add5(1,2,3,4,5));
            Console.ReadLine();
        }
        
        static void Add()
        {
            Console.WriteLine("Added!");
        }

        static int Add2(int number1, int number2)
        {
            var result = number1 + number2;
            return result;
        }

        static int Add3(int number1, int number2=30) // default parameter
        {
            var result = number1 + number2;
            return result;
        }

        static int Add4(ref int number1, int number2) // same thing can be done using ref or out
        {
            number1 = 30;
            return number1 + number2;
        }

        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }

        static int Add5(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
