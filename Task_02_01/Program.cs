﻿namespace Task_02_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите первое число (a)");
            double a=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите второе число (b)");
            double b=Convert.ToDouble(Console.ReadLine());

            double summAB = a + b;
            Console.WriteLine("сумма чисел: " + summAB);

            double multipleAB = a * b;

            Console.WriteLine("произведение чисел: " + multipleAB);
            double diffAB = a - b;
            Console.WriteLine("разность чисел: " + diffAB);
            double divAB;
            if (b !=0)
            {
                divAB = a / b;
                Console.WriteLine("деление на a и b: " + divAB);
            }
            else
            {
                Console.WriteLine("деление на ноль");
            }
        }
    }
}
