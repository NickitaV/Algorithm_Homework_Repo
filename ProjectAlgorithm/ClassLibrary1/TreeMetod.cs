using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAlgorithm
{
    public class TreeMetod<T>
    {
        public Tree<T> Head { get; set; }

        public void AddAfterThis(int parentValue, T value)
        {

            Tree<T> numberValue = GetNodeByValue(parentValue);
            Tree<T> newValue = new Tree<T>(value);
            if (numberValue == null) { Console.WriteLine($"Значения [{parentValue}] в дереве нет"); }
            else
            {

                if (Convert.ToInt32(value) < Convert.ToInt32(numberValue.Value))
                {
                    numberValue.Left = newValue;


                }
                else
                {
                    numberValue.Right = newValue;
                }

            }
        }

        public void AcrossTreeDepth()
        {


            Queue<int> treeValue = new Queue<int>();

            Tree<T> current = Head;
            Across(current);
            foreach (int Val in treeValue) { Console.WriteLine(Val); }
            void Across(Tree<T> current)
            {

                if (current != null)
                { treeValue.Enqueue(Convert.ToInt32(current.Value)); }

                else { return; }

                Across(current.Left);
                Across(current.Right);


            }



        }

        public void AcrossTreeWidth()
        {

            Queue<int> treeValue = new Queue<int>();

            Tree<T> current = Head;

            var parentsNewQueue = new Queue<Tree<T>>();
            parentsNewQueue.Enqueue(current);
            while (parentsNewQueue.Count > 0)
            {
                current = parentsNewQueue.Dequeue();

                treeValue.Enqueue(Convert.ToInt32(current.Value));
                if (current.Left != null)
                    parentsNewQueue.Enqueue(current.Left);
                if (current.Right != null)
                    parentsNewQueue.Enqueue(current.Right);

            }
            foreach (int Val in treeValue) { Console.WriteLine(Val); }



        }

        public void AddItem(T value)
        {
            Tree<T> newData = new Tree<T>(value);
            if ((Head == null) || (Head == newData))
            {
                Head = newData;
                return;

            }
            else
            {


                Tree<T> currentNode = Head;
                bool addControl = true;
                while (addControl == true)
                {
                    if (Convert.ToInt32(newData.Value) < Convert.ToInt32(currentNode.Value))
                    {
                        if (currentNode.Left == null)
                        {
                            currentNode.Left = new Tree<T>(value);

                            addControl = false;
                        }
                        else { currentNode = currentNode.Left; }
                    }
                    else
                    {
                        if (currentNode.Right == null)
                        {
                            currentNode.Right = new Tree<T>(value);

                            addControl = false;
                        }


                        else { currentNode = currentNode.Right; }
                    }
                }


            }


        }





        public Tree<T> FindParent(int value, out Tree<T> parent)
        {

            Tree<T> current = Head;
            parent = null;


            while (current != null)
            {


                if (Convert.ToInt32(current.Value) > value)
                {

                    parent = current;
                    current = current.Left;
                }
                else if (Convert.ToInt32(current.Value) < value)
                {

                    parent = current;
                    current = current.Right;
                }
                else
                {

                    break;
                }
            }
            return current;
        }
        public void RemoveItem(int value)
        {


            Tree<T> current = FindParent(value, out Tree<T> parent);





            if (current == null)
            {
                return;
            }

            else
            {
                if ((current.Left == null) && (current.Right == null))
                {
                    if (Convert.ToInt32(parent.Value) > value)
                    {
                        parent.Left = null;
                    }
                    else
                    {
                        parent.Right = null;
                    }
                }
                else if (current.Left == null)
                {
                    if (Convert.ToInt32(parent.Value) > value)
                    {
                        parent.Left = current.Right;
                    }
                    else
                    {
                        parent.Right = current.Right;
                    }


                }
                else if (current.Right == null)
                {
                    if (Convert.ToInt32(parent.Value) > value)
                    {
                        parent.Left = current.Left;
                    }
                    else
                    {
                        parent.Right = current.Left;
                    }

                }
                else
                {

                    if (parent == null)
                    {




                        current = Head;
                        var buf = current.Left;

                        if (Head.Left == null)
                        {


                            Head.Value = current.Right.Value;

                            current.Right = current.Left.Right;

                        }
                        else
                        {

                            Head.Value = current.Left.Value;

                            current.Left = current.Left.Left;


                        }
                        AddItem(current.Value);


                    }
                    else
                    {

                        if (Convert.ToInt32(parent.Value) > value)
                        {

                            parent.Left = current.Right;

                        }
                        else
                        {

                            parent.Right = current.Right;

                        }
                    }



                }
            }
        }
        public Tree<T> GetNodeByValue(int value)
        {
            Tree<T> current = Head;

            Tree<T> NodeByValue(int value, Tree<T> current)
            {

                if (Convert.ToInt32(current.Value) == value)
                {
                    return current;
                }


                if (value < Convert.ToInt32(current.Value))
                {
                    if (current.Left != null)
                    {
                        current = current.Left;
                        return NodeByValue(value, current);
                    }
                    else return null;

                }
                else
                {
                    if (current.Right != null)
                    {
                        current = current.Right;
                        return NodeByValue(value, current);
                    }
                    else return null;
                }

            }

            current = NodeByValue(value, current);
            return current;
        }


        public void PrintTree()
        {
            void Print(Tree<T> newData, string indent = "", Nullable<Side> side = null)
            {


                if (newData != null)
                {
                    string sideN = "";
                    if (side == null)
                    {
                        sideN = "#";

                    }
                    else
                    {
                        if (side == Side.Left) { sideN = "L"; } else { sideN = "R"; }
                    }


                    Console.WriteLine($"{indent} [{sideN}]:{newData.Value}");
                    indent += new string(' ', 3);

                    Print(newData.Left, indent, Side.Left);
                    Print(newData.Right, indent, Side.Right);
                }
            }
            Print(Head);
        }
    }
}
