using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {//Задание 1. Приложение по определению чётного или нечётного числа
         

            Console.WriteLine("\nВведите число:");
            int userNumber = int.Parse(Console.ReadLine());
            if (userNumber %2 == 0)  { Console.WriteLine("Число четное"); }
            else { Console.WriteLine("Число нечетное."); }
            Console.ReadKey();
        }
    }
}
