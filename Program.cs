using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторна_1
{
    internal class Program
    {
        enum test1Status { Pass = 1, Fail = 2, Blocked = 3, WP = 4, Unexecuted = 5 }
        struct RGB
        {
            public byte red;
            public byte green;
            public byte blue;
        }
        enum HTTPError
        {
            Bad_Request = 400,
            Unauthorized = 401,
            Payment_Required = 402,
            Forbidden = 403,
            Not_Found = 404
        }
        static void Main(string[] args)
        {
            //Task 1.1

            int day;
            int month;
            day = Convert.ToInt32(Console.ReadLine());
            month = Convert.ToInt32(Console.ReadLine());
            string result = (day > 0) && (day <= 31) && (month > 0) && (month <= 12) ? "Число може бути днем i мiсяцем" : "Число не може бути днем i мiсяцем";
            Console.WriteLine(result);

            //Task 1.2

            double a = double.Parse(Console.ReadLine());
            var x = (a * 10) % 10;
            var y = (a * 100) % 10;
            int sum = (int)(x + y);
            Console.WriteLine(sum);


            //Task 1.3

            int hour;
            hour = Convert.ToInt32(Console.ReadLine());
            string resul = (hour >= 5) && (hour < 11) ? "Доброго ранку!" : (hour >= 11) && (hour < 17) ? "Добрий день!" : (hour >= 17) && (hour <= 21) ? "Добрий вечір!" : "Доброї ночі!";
            Console.WriteLine(resul);

            //Task 1.4

            Console.WriteLine((test1Status)1);
            Console.ReadKey();
            Console.ReadLine(); 

            //Task 1.5

            RGB white;
            white.red = 0;
            white.green = 0;
            white.blue = 0;

            RGB black;
            black.red = 255;
            black.green = 255;
            black.blue = 255;

           //Task 2.1

            float num1, num2, num3;
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32((Console.ReadLine()));
            num3 = Convert.ToInt32((Console.ReadLine()));
            string check1 = (num1 >= -5) && (num1 <= 5) ? "num1 належить дiапазону" : "num1 не належить дiапазону";
            string check2 = (num2 >= -5) && (num2 <= 5) ? "num2 належить дiапазону" : "num2 не належить дiапазону";
            string check3 = (num3 >= -5) && (num3 <= 5) ? "num3 належить дiапазону" : "num3 не належить дiапазону";
            Console.WriteLine(check1);
            Console.WriteLine(check2);
            Console.WriteLine(check3);

            //Task 2.2
            int numb1, numb2, numb3;
            numb1 = Convert.ToInt32(Console.ReadLine());
            numb2 = Convert.ToInt32(Console.ReadLine());
            numb3 = Convert.ToInt32(Console.ReadLine());
            int[] arr = { numb1, numb2, numb3 };
            Console.WriteLine("min=" + arr.Min());
            Console.WriteLine("max=" + arr.Max());

            //Task 2.3
            int errCode;
            errCode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((HTTPError)errCode);
            Console.ReadKey();
            Console.ReadLine();
        }
    }


}
