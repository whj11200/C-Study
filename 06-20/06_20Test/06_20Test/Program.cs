using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _06_20Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            for (i = 0; i < 10; i++)
            {
                for (j = 0; j < 10 - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 0; j< i + 1; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            for (i = 0; i < 10; i++)
            {
                for (j = 0; j <  i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 0; j < 10 -i; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
           
        }
    }
}
