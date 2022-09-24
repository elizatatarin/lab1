using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторна_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1.1

            int day;
            int month;
            day = Convert.ToInt32(Console.ReadLine());
            month = Convert.ToInt32(Console.ReadLine());
            string result = (day > 0) && (day < 31) && (month > 0) && (month < 12) ? "Число може бути днем i мiсяцем" : "Число не може бути днем i мiсяцем";
            Console.WriteLine(result);

            //Task 1.3

            int hour;
            hour = Convert.ToInt32(Console.ReadLine());
            string resul = (hour >= 5) && (hour < 11) ? "Доброго ранку!" : (hour >= 11) && (hour < 17) ? "Добрий день!" : (hour >= 17) && (hour <= 21) ? "Добрий вечір!" : "Доброї ночі!";
            Console.WriteLine(resul);
        }
    }

    
 }
