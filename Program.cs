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
        {
            #region Task_3_1 Задание 1.Приложение по определению чётного или нечётного числа


            //Console.WriteLine("\nВведите число:");
            //int userNumber = int.Parse(Console.ReadLine());
            //if (userNumber % 2 == 0) { Console.WriteLine("Число четное"); }
            //else { Console.WriteLine("Число нечетное."); }
            //Console.ReadKey();
            #endregion
            #region Task_3_2 Задание 2.Программа подсчёта суммы карт в игре «21»

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
            #endregion
            #region Task_3_3 Задание 3.Проверка простого числа


            //bool bCondition = false;
            //Console.WriteLine("Введите целое число");
            //int nUser = int.Parse(Console.ReadLine());
            //int nvCount = 1;
            //while (nvCount <= nUser - 1)
            //{

            //    if (nUser % 2 == 0) bCondition = true;
            //    nvCount++;
            //}
            //if (bCondition == false)
            //    Console.WriteLine("Число простое");
            //else Console.WriteLine("Число не простое");
            //Console.ReadKey();
            #endregion
            #region Task_3_4 Задание 4.Наименьший элемент в последовательности

            //Console.WriteLine("Введите длину последовательности");
            //int nvLengt = int.Parse(Console.ReadLine());
            //int nvMin = int.MaxValue;
            //Console.WriteLine("Введите последовательность целых чисел (как положительных, так и отрицательных");
            //for (int i = 1; i <= nvLengt; i++)
            //{ int nvUser = int.Parse(Console.ReadLine());
            //    if (nvUser < nvMin)  nvMin = nvUser;  
            //}
            //Console.WriteLine("Наименьшее число: " + nvMin);
            //Console.ReadKey();

            #endregion
            #region Task_3_5 Задание 5.Игра «Угадай число»
            
            //Console.WriteLine("Поиграем в \" Угадай число \", \n Введите максимальное число диапазона");
            //int nvMax = int.Parse(Console.ReadLine());
            //Random rand = new Random();
            //int iiNumber = rand.Next(1, nvMax);
            //int nvCount = 0;
            //string userNumber;

            //while (true)
            //{
            //    Console.Write("\nВведите число: ");
            //    nvCount++;
            //     userNumber = Console.ReadLine();
            //    if (userNumber == string.Empty) 
            //    {   
            //        Console.WriteLine("Устал? Загаданное число: " + iiNumber);
            //        Console.ReadKey();
            //        break;
            //    }

            //    if (Convert.ToInt32(userNumber) < iiNumber)
            //    {
            //        Console.WriteLine("Введенное число меньше загаданного. Попробуйте ещё раз");
            //    }
            //    else if (Convert.ToInt32(userNumber) > iiNumber)
            //    {
            //        Console.WriteLine("Введенное число больше загаданного. Попробуйте ещё раз");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Поздравляю, число угадано! Число попыток: {nvCount}.");
            //        Console.ReadKey();
            //        break;
            //    }
            //}
            #endregion
        }
    }
}
