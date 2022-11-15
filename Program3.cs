using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soal3
{
    class Program
    {
        //برنامه ای که ک.م.م و ب.م.م را حساب میکند
        static void Main(string[] args)
        {
            Console.WriteLine("enter number 1 : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number 2 : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("bmm = " + bmm(num1, num2));
            Console.WriteLine("kmm : " + kmm(num1, num2));
            Console.ReadKey();
        }
        private static int bmm(int x,int y)
        {
            int t=1;
            for(int i=1;i<=x;i++)
            {
                if ((x % i == 0) && (y % i == 0) && (i >= t))
                    t = i;
            }
            return t;
        }
        private static int kmm(int x,int y)
        {
            int m = x;
            for(int i=1;i>=1;i++)
            {
                m = x * i;
                if ((m % y == 0))
                    break;
            }
            return m;
        }
    }
}