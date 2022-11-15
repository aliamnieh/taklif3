using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soal5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a number : ");
            double n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("rishe dovom is : " + radikal.jazr(n));
            Console.ReadKey();
        }
    }
    class radikal
    {
        public static double jazr(double number)
        {
            return Math.Sqrt(number);
        }
    }
}
