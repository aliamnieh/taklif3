using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soal4
{
    class Program
    {
        //سوال مربوط به درصد بهره ی سالیانه
        static void Main(string[] args)
        {
            Console.WriteLine("how much money do you have in your bank account ?");
            double supply = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("what is the profit pecent ?");
            int percent = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the amount of money you want to achieve : ");
            double goal = Convert.ToDouble(Console.ReadLine());
            if (percent > 0 && percent <= 100) f(supply, percent, goal);
            else Console.WriteLine("the percent you have entered is incorrect!");
            Console.ReadKey();

        }
        private static void f(double supply,int percent,double goal)
        {
            int i;
            for( i=1;i>=1;i++)
            {
                supply += (supply * percent) / (100 * 1.0);
                if (supply >= goal) break;
            }
            Console.WriteLine("after " + i + " years you will have this amount of money.");
        }
    }
}
