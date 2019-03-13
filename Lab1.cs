using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите число a :");
            int a = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Ответ:"+ (a*a*a));
            Console.ReadLine();

        }
    }
}
