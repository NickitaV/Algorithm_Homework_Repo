using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectAlgorithm
{
    public class Fib
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
