using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_TriangleShape
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter how many rows:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            int num = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(num + " ");
                    num++;
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " "); 
                }
                Console.WriteLine();
            }
        }
    }
}