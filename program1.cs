using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soal1
{
    class Program
    {
        //برنامه ای که توان دوم عدد را بدست اورد
        static void Main(string[] args)
        {
            Console.WriteLine("enter an integer : ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(x + " be tavan 2 = " + f(x));
            Console.ReadKey();
        }
        private static int f(int x)
        {
            return (x * x);
        }
    }
}
