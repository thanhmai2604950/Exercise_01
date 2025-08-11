using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_01
{
    internal class Exercise_1
    {
        static void Main()
        {
            //siuuuuuuuu
           Ex03();  
        }
        /// <summary>
        /// 1. to Add/ Sum Two Numbers
        /// </summary>
        static void Ex01()
        {
            int a = 10, b = 20;
            int c = a + b;
            Console.WriteLine($"{a}+{b}={c}");
        }
        /// <summary>
        /// to Swap values of Two Variables
        /// </summary>
        static void Ex02()
        {
            int a = 10, b = 20;
            Console.WriteLine($"truoc khi doi a={a},b={b}");// to Swap Two Numbers
            int tam = a;
            a = b;
            b = tam;
            Console.WriteLine($"sau khi doi a={a}, b={b}");
        }
        /// <summary>
        /// to Mutiply two Floating Point Numbers
        /// </summary>
        static void Ex03()
        {
            float e = 5.5f, f = 2.0f;
            float g = e * f;
            Console.WriteLine($"{e} * {f} = {g}");
        }
    }
}
