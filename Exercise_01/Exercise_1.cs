using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_01
{
    internal class Exercise_1
    {
        static void Main()
        {
            Ex01();
            Ex02();
            Ex03();
            Ex04();
            Ex05();
            Ex06();
            Ex07();
            Ex08();
            Ex09();
            Ex10();
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
        /// <summary>
        /// to convert feet to meter
        /// </summary>
        static void Ex04()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            double a = 10.0; // feet
            Console.WriteLine($"Trước khi đổi: {a} feet");
            double b = a * 0.3048; // convert feet to meter
            Console.WriteLine($"Sau khi đổi: {b} meter");
        }
        /// <summary> 
        /// to convert Celsius to Fahrenheit and vice versa
        /// </summary>
        static void Ex05()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            double a = 25.0;
            double b = (a * 9 / 5) + 32;
            Console.WriteLine($"{a} độ C = {b} độ F");
            b = 77.0;
            a = (b - 32) * 5 / 9;
            Console.WriteLine($"{b} độ F = {a} độ C");
        }
        /// <summary>
        /// to find the Size of data types
        /// </summary>
        static void Ex06()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine($"Kích thước của kiểu int: {sizeof(int)} bytes");
            Console.WriteLine($"Kích thước của kiểu float: {sizeof(float)} bytes");
            Console.WriteLine($"Kích thước của kiểu double: {sizeof(double)} bytes");
            Console.WriteLine($"Kích thước của kiểu char: {sizeof(char)} bytes");
            Console.WriteLine($"Kích thước của kiểu bool: {sizeof(bool)} bytes");
            Console.WriteLine($"Kích thước của kiểu long: {sizeof(long)} bytes");
            Console.WriteLine($"Kích thước của kiểu short: {sizeof(short)} bytes");
        }
        /// <summary>  
        /// . to Print ASCII Value (tip: read character, print number of this char)
        /// </summary>
        static void Ex07()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Hãy nhập một ký tự bất kỳ: ");
            char a = Console.ReadKey().KeyChar;
            int b = (int)a; // Convert char to ASCII value
            Console.WriteLine($"\nGiá trị ASCII của '{a}' là {b}");
        }
        /// <summary>  
        /// to Calculate Area of Circle
        /// </summary>
        static void Ex08()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập bán kính hình tròn (cm): ");
            double R = Convert.ToDouble(Console.ReadLine());
            double S = R * R * 3.14;
            Console.WriteLine($"Diện tích hình tròn có bán kính {R} là {S} cm^2");
        }
        /// <summary>   
        /// to Calculate Area of Square
        /// </summary>
        static void Ex09()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập cạnh của hình vuông (m): ");
            double a = Convert.ToDouble(Console.ReadLine());
            double S = a * a;
            Console.WriteLine($"Diện tích hình vuông có cạnh {a} là {S} m^2");
        }
        /// <summary>  
        /// to convert days to years, weeks and days
        /// </summary>
        static void Ex10()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập số ngày: ");
            int days = Convert.ToInt32(Console.ReadLine());
            int years = days / 365;
            int remainingDays = days % 365; // Số ngày còn lại sau khi tính năm
            int weeks = remainingDays / 7; // Số tuần trong số ngày còn lại
            int finalDays = remainingDays % 7; // Số ngày còn lại sau khi tính tuần
            Console.WriteLine($"{days} ngày bằng {years} năm, {weeks} tuần và {finalDays} ngày.");
        }
    }
}
