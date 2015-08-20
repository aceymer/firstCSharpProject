using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class MathUtil
    {
        public bool IsEven(int number)
        {
            return number%2 == 0;
        }

        public bool IsOdd(int number) {
            return number % 2 == 1;

            //return false;
        }
    }
}
