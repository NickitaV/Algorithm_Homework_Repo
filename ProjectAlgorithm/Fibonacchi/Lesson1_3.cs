using System;

namespace Fibonacchi
{
    class Lesson1_3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число(колличество чисел в ряду Фибоначчи)");
            long n = long.Parse(Console.ReadLine());
            Fib fib = new Fib();
            fib.FibRekurs(n);
            fib.FibСycle(n);


        }
    }
}
