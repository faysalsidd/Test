using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = AMethod(true, true, false);
            Console.WriteLine(a);
        }

        private static int AMethod(bool first, bool second, bool third)
        {
            int OptionOne = 1;
            int OptionTwo = 2;

            if (!first && second)
            {
                return OptionOne;
            }
            else if ((!second) || (!third) || second )
            {
                return OptionTwo;
           
            }
            else
                 return OptionOne;

        }
    }
}
