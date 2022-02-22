using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Diagnostics;
namespace ProjectAlgorithm

{
    internal class StartMenu : IStartMenu
    {


        public void Input(out int LessonNumber, out int WorkNumber)
        {
            Console.WriteLine("Введите номер урока");
            LessonNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите номер задания в уроке");
            WorkNumber = Convert.ToInt32(Console.ReadLine());
        }
        public void Choice(int LessonNumber, int WorkNumber)
        {


            if ((LessonNumber == 1) && (WorkNumber == 1))
            {
                primeNumberTest primeNumber = new primeNumberTest();
                primeNumber.NumberTest();
            }

            if ((LessonNumber == 1) && (WorkNumber == 2))
            {
                File.WriteAllText(path: "lesson1_2.txt", "асимптоматическая сложность функции во 2 задании O(N3 + 2)");
                string TxtFile = File.ReadAllText(path: "lesson1_2.txt");
                Console.WriteLine(TxtFile);
            }
            if ((LessonNumber == 1) && (WorkNumber == 3))
            {
                Fib fib = new Fib();
                long input = fib.Input();
                fib.FibRekurs(input);
                fib.FibСycle(input);
            }
            if ((LessonNumber == 2) && (WorkNumber == 1))
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

            if ((LessonNumber == 3) && (WorkNumber == 1))
            {
                Console.WriteLine("Введите количество точек");
                int PointSum = Convert.ToInt32(Console.ReadLine());
                StopwatchMassiv time = new StopwatchMassiv();
                time.Time(PointSum, out double classTime, out double structTime);
                Console.WriteLine("Количество точек|PointStructDouble | PointClassDouble |    Ratio");
                Console.WriteLine($"   {PointSum}                {structTime}                   {classTime}        {structTime / classTime}");
            }

            if ((LessonNumber == 4) && (WorkNumber == 1))
            {

                TreeMetod<int> treeMetod = new TreeMetod<int>();
               
                treeMetod.AddItem(16);
                treeMetod.AddItem(10);
                treeMetod.AddItem(7);
                treeMetod.AddItem(40);
                treeMetod.AddItem(100);
                treeMetod.AddItem(50);

                treeMetod.PrintTree();

                Tree<int> Find = treeMetod.GetNodeByValue(40);

                if (Find != null)
                {
                    Console.WriteLine($"Найдено: {Find.Value}");
                }
                else { Console.WriteLine("Значения не найдено"); }

                treeMetod.RemoveItem(100);
                treeMetod.RemoveItem(10);

                treeMetod.PrintTree();

                treeMetod.AddAfterThis(16, 15);
                treeMetod.AddAfterThis(16, 600);
                treeMetod.AddAfterThis(600, 20);
                treeMetod.AddAfterThis(15, 14);
                treeMetod.AddAfterThis(15, 0);
           
                treeMetod.AddAfterThis(600,500 );
                treeMetod.AddAfterThis(600, 800);
                treeMetod.AddAfterThis(500, 200);
                treeMetod.AddAfterThis(500, 536);
                treeMetod.AddAfterThis(15,50);

                treeMetod.PrintTree();
                treeMetod.AcrossTreeDepth();

                Console.WriteLine("-----------");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                treeMetod.AcrossTreeWidth();


            }


        }

    }

}
