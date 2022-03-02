using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Diagnostics;
namespace ProjectAlgorithm

{
    internal class StartMenu
    {


        public void Input(out int LessonNumber, out int WorkNumber)
        {
            Console.WriteLine("Lesson 1: [1]- primeNumber\n          [2]- text\n          [3]- Fib\nLesson 2: [1]- LinkedList\nLesson 3: [1]- PointStruct&PointClass\nLesson 4: [1]- Tree");
            Console.WriteLine("Введите номер урока(от 1 до 4)");
            string newRead = Console.ReadLine();
            if ((String.IsNullOrEmpty(newRead)) || ((Convert.ToInt32(newRead) < 1) || (Convert.ToInt32(newRead) > 4)))
            {
                Console.WriteLine("Вы ввели неправильное значение"); LessonNumber = 0; WorkNumber = 0;
            }
            else
            {
                LessonNumber = Convert.ToInt32(newRead);

                Console.WriteLine("Введите номер задания в уроке(список выше)");
                string workRead = Console.ReadLine();
                if (String.IsNullOrEmpty(workRead)) { Console.WriteLine("Вы ввели пустую строку"); WorkNumber = 0; }

                else WorkNumber = Convert.ToInt32(workRead);
            }
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

                treeMetod.AddAfterThis(600, 500);
                treeMetod.AddAfterThis(600, 800);
                treeMetod.AddAfterThis(500, 200);
                treeMetod.AddAfterThis(500, 536);
                treeMetod.AddAfterThis(15, 50);

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
