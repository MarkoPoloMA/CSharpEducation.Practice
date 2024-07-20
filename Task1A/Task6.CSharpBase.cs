using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1A
{
    class ClassTask6
    {
        public double Task5A(double catheterFirst, double catheterSecond)
        {
            double gip = Math.Sqrt(Math.Pow(catheterFirst, 2) + Math.Pow(catheterSecond, 2));
            Console.WriteLine($"При катетах {catheterFirst}, {catheterSecond} - гипотенуза равна: " + gip);

            return gip;
        }
        public double Task5B(double catheterFirst, double gip)
        {
            double catheterSecond = Math.Sqrt(Math.Pow(gip, 2) + Math.Pow(catheterFirst, 2));
            Console.WriteLine($"При катете {catheterFirst} и гипотенузе {catheterSecond} - второй катет равен: " + catheterSecond);

            return gip;
        }
    }
}
