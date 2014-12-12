using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2App
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double i, count, f1 = 0, f2 = 1, f3 = 0;
            Console.Write("Enter the Limit : ");
            count = double.Parse(Console.ReadLine());
            Console.WriteLine(f1);
            Console.WriteLine(f2);
            for (i = 0; i <= count; i++)
            {
                f3 = f1 + f2;
                f1 = f2;
                f2 = f3;
                    if ((f3 % 2) == 0 && (f3<=40000000))
                   
                    {
                        Console.WriteLine(f3);   
                }
                   
            }
            
            Console.ReadLine();
        }
    }
}

