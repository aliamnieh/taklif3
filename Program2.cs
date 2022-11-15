using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soal2
{
    class Program
    {
        //برنامه ای سن کاربر را برحسب سال و ماه و هفته و روز محاسبه کند
        static void Main(string[] args)
        {
            Console.WriteLine("please enter your age per day : ");
            int age = Convert.ToInt32(Console.ReadLine());
            f(age);
            Console.ReadKey();
        }
        private static void f(int age)
        {
            int year = age / 365;
            age %= 365;
            int month = age / 30;
            age %= 30;
            int week = age / 7;
            age %= 7;
            int day = age;
            Console.WriteLine("your age is : " + year + " sal " + month + " mah " + week + " hafteh " + day + " rooz ");
        }
    }
}
