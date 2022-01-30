using System;

namespace ProjectAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            long number = long.Parse(Console.ReadLine());
            primeNumberTest prime = new primeNumberTest();
            prime.NumberTest(number);



           

        }
    }
}
