using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstHW
{
    class Program
    {
        static void Main(string[] args)
        {
            #region T1
            Console.Write("Enter first value (int): ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second value (int): ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"a + b = {a + b}, a - b = {a - b}, a * b = {a * b}, a / b = {a / b}");
            #endregion

            #region T2
            Console.WriteLine("How are you?");
            string answer = Console.ReadLine();
            Console.WriteLine($"You are {answer}");
            #endregion

            #region T3
            Console.Write("Enter first value (char): ");
            char first = Convert.ToChar(Console.ReadLine());
            Console.Write("Enter second value (char): ");
            char second = Convert.ToChar(Console.ReadLine());
            Console.Write("Enter third value (char): ");
            char third = Convert.ToChar(Console.ReadLine());
            Console.WriteLine($"You enter = {first}, {second}, {third}");
            #endregion

            #region T3
            int s = 3;
            int n = 3;
            bool c = s == n;
            Console.WriteLine(c);
            #endregion

            #region B
            Console.Write("Please write the size of side (int): ");
            int side = Int32.Parse(Console.ReadLine());
            int area = side * side;
            int per = side * 4;
            Console.WriteLine($"Area = {area}, perimetr = {per}");
            #endregion

            #region C
            string name;
            int age;
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.WriteLine($"How old are you, {name}?");
            age = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Hi {0}, you are {1}", name, age);
            #endregion

            #region D
            double r;
            Console.Write("Please enter radius (double): ");
            r = Convert.ToDouble(Console.ReadLine());
            double pi = Math.PI;
            double L = 2 * pi * r;
            double S = pi * r * r;
            double volume = (4 / 3) * pi * r * r * r;
            Console.WriteLine("length = {0}, area = {1}, volume = {2}", L, S, volume);
            Console.ReadKey();
            #endregion
        }
    }
}
