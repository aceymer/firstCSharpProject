using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("basic number div 2 count");
            GetUserData();
            Console.ReadLine();
        }

        static void GetUserData()
        {
            Console.Write("please enter a number: ");
            bool numberCorrect = false;
            int numberAsInt = -1;
            while (!numberCorrect)
            {
                string numberAsString = Console.ReadLine();
                try
                {
                    numberAsInt = int.Parse(numberAsString);
                    numberCorrect = true;
                }
                catch {
                    Console.Write("Thats NOT a number, please enter a number:");
                }
            }


            //changes echo colour
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;

            var util = new MathUtil();
            for (var number = 1; number < numberAsInt; number++)
            {
                if (util.IsEven(number))
                {
                    Console.WriteLine("" + number);
                }
            }


            
            //Restore previous color
            Console.ForegroundColor = prevColor;
        }
    }

    
}
