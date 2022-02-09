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
            if (LessonNumber == 2)
            {
                switch (WorkNumber)
                {
                    case 1:
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
                        Console.WriteLine($"Общее колличество: { node.GetCount()}");
                        break;
                }
            }

            else
            {
                Console.WriteLine("Эти задания ещё не выполнены");
            }

        }
    }




}
