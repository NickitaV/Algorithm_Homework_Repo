using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Diagnostics;
namespace ProjectAlgorithm

{
    internal class StartMenu : IStartMenu
    {
        private void DoSomething(int k, int n)
        {
            if ((k == 1) && (n == 1))
            {
                primeNumberTest primeNumber = new primeNumberTest();
                primeNumber.NumberTest();
            }

            if ((k == 1) && (n == 2))
            {
                File.WriteAllText(path: "lesson1_2.txt", "асимптоматическая сложность функции во 2 задании O(N3 + 2)");
                string TxtFile = File.ReadAllText(path: "lesson1_2.txt");
                Console.WriteLine(TxtFile);
            }
            if ((k == 1) && (n == 3))
            {
                Fib fib = new Fib();
                long input = fib.Input();
                fib.FibRekurs(input);
                fib.FibСycle(input);
            }
            if ((k == 2) && (n == 1))
            {

                LinkedList<int> node = new LinkedList<int>();
                node.AddNode(50);
                node.AddNode(80);
                node.AddNode(90);
                node.AddNode(70);
                node.AddNode(89);
                node.AddNode(500);
                node.AddNode(800);
                Node<int> currentNode = node.FindNode(800);
                node.RemoveNode(currentNode);
                node.AddNodeAfter(currentNode, 5);
                node.RemoveNode(2);
                Console.WriteLine($"Общее колличество { node.GetCount()}");
            }

            if ((k == 3) && (n == 1))
            {
                Console.WriteLine("Введите количество точек");
                int PointSum = Convert.ToInt32(Console.ReadLine());
                StopwatchMassiv time = new StopwatchMassiv();
                time.Time(PointSum, out double classTime, out double structTime);
                Console.WriteLine("Количество точек|PointStructDouble | PointClassDouble |    Ratio");
                Console.WriteLine($"   {PointSum}                {structTime}                   {classTime}        {structTime / classTime}");
            }
        }
        public void Input(out int LessonNumber, out int WorkNumber)
        {
            Console.WriteLine("Введите номер урока");
            LessonNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите номер задания в уроке");
            WorkNumber = Convert.ToInt32(Console.ReadLine());
        }
        public void Choice(int LessonNumber, int WorkNumber, int k, int n)
        {


            if ((LessonNumber == k) && (WorkNumber == n))
            {
                DoSomething(k, n);
            }



        }

    }

}
