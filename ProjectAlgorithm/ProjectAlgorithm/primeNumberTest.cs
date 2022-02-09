using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectAlgorithm
{
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
}
