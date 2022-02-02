using System;
using System.IO;
namespace ProjectAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер урока:");
            int LessonNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите номер задания в уроке:");
            int WorkNumber = Convert.ToInt32(Console.ReadLine());
            primeNumberTest primeNumber = new primeNumberTest();
            Fib fib = new Fib();
            if (LessonNumber == 1)
            {
                switch (WorkNumber)
                {
                    case 1:
                        primeNumber.NumberTest();
                        break;
                    case 2:
                        File.WriteAllText(path: "lesson1_2.txt", "асимптоматическая сложность функции во 2 задании: O(N*3+2)");
                        string TxtFile = File.ReadAllText(path: "lesson1_2.txt");
                        Console.WriteLine(TxtFile);
                        break;
                    case 3:
                        long input = fib.Input();
                        fib.FibRekurs(input);
                        fib.FibСycle(input);
                        break;

                }
            }
            else {
                Console.WriteLine("Эти задания ещё не выполнены");
            }

        }
    }

    public class primeNumberTest
    {
        public void NumberTest()
        {
            Console.WriteLine("Введите число");
            long number = long.Parse(Console.ReadLine());

            int d = 0;
            int i = 2;
            while (i < number)
            {
                if (number % i == 0)
                {
                    d++;

                }
                i++;
            }
            if (d == 0) { Console.WriteLine($"Число {number} простое"); }
            else Console.WriteLine($"Число {number} не простое");
        }

    }

    class Fib
    {
        public long Input()
        {
            Console.WriteLine("Введите целое число(колличество чисел в ряду Фибоначчи)");
            long n = long.Parse(Console.ReadLine());
            return n;
        }
        public void FibRekurs(long n)
        {
            static long FRekurs(long n)
            {
                if (n == 0) { return 0; }
                if ((n == 1) || (n == 2)) { return 1; }
                else return FRekurs(n - 1) + FRekurs(n - 2);
            }
            for (int i = 0; i < n; i++) { Console.WriteLine(FRekurs(i)); }
        }
        public void FibСycle(long n)
        {
            long fOne = 0;
            long fTwo = 1;
            long fSum;
            long[] FibArr = new long[n];
            FibArr[0] = 0;
            FibArr[1] = 1;

            for (int f = 2; f < n; f++)
            {

                fSum = fOne + fTwo;
                FibArr[f] = fSum;
                fOne = fTwo;
                fTwo = fSum;
            }


            for (int i = 0; i < n; i++) Console.WriteLine(FibArr[i]);
        }

    }
}
