using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace largestprimefactorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            long dividend = 600851475143;
            long n = 2;

            while (n < dividend)
            {
                if (dividend % n == 0)
                {
                    dividend = dividend / n;

                }
                n++;
            }
            Console.WriteLine(n);
            Console.ReadKey();

        }
    }
}
