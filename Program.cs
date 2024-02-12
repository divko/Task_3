using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {//Задание 1. Приложение по определению чётного или нечётного числа


            //Console.WriteLine("\nВведите число:");
            //int userNumber = int.Parse(Console.ReadLine());
            //if (userNumber %2 == 0)  { Console.WriteLine("Число четное"); }
            //else { Console.WriteLine("Число нечетное."); }
            //Console.ReadKey();

            //            Задание 2.Программа подсчёта суммы карт в игре «21»


            //Console.WriteLine("\nПриветствую в игре '21'. Сколько на руках карт?");

            //int nvCount= int.Parse(Console.ReadLine());

            //int nvSum = 0;

            //for (int i = 0; i < nvCount; i++) 
            //{ Console.Write("Введите номинал следующей карты ");

            // string  nvUser = (Console.ReadLine());  
            //        switch (nvUser)
            //    {
            //        case "K": nvSum = nvSum + 10;break;
            //        case "J": nvSum = nvSum + 10; break;
            //        case "Q": nvSum = nvSum + 10; break;
            //        case "T": nvSum = nvSum + 10; break;
            //        default: nvSum = nvSum + int.Parse(nvUser); break;
            //    }



            //}
            //Console.WriteLine("Сумма карт на руках пользователя: " + nvSum);
            //Console.ReadKey();

//            Задание 3.Проверка простого числа

bool bCondition = false;
            Console.WriteLine("Введите целое число");
            int nUser = int.Parse(Console.ReadLine());
            int nvCount = 1;
            while (nvCount < nUser-1) 
            {
                
                if (nUser%2 == 0) bCondition = true;
                nvCount++;
            }
            if (bCondition == false)
            Console.WriteLine("Число простое"); 
            else Console.WriteLine("Число не простое");
                Console.ReadKey();
        }
    }
}
