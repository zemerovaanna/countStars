using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Вводим число ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(n + new string('*', n));
            Console.ReadKey();
        }
    }
}
