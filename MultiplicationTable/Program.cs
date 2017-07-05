using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t* * * 九九の表 * * *");
            Console.WriteLine("\t|\t1\t2\t3\t4\t5\t6\t7\t8\t9");
            Console.WriteLine("--------------------------------------------------------------------------------------------------");

            for (int a = 1; a < 10; a++)
            {
                for (int b = 1; b < 10; b++)
                {
                    if (b == 1) Console.Write(a + "\t|\t");
                    Console.Write(a * b + "\t");
                }
                Console.Write("\n");
            }

        }
    }
}
