using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectAlgorithm
{
    internal class LinkedList<T> : ILinkedList<T>
    {
        public Node<T> First { get; set; }

        public void AddNode(T value)
        {
            Node<T> newNode = new Node<T>(value);

            if (First == null)
            {
                First = newNode;
            }
            else
            {
                Node<T> currentNode = First;
                while (currentNode.NextNode != null)
                {
                    currentNode = currentNode.NextNode;
                }
                currentNode.NextNode = newNode;
                newNode.PrevNode = currentNode;
            }

        }

        public int GetCount()
        {
            Node<T> newNode = First;
            int Count = 0;
            do { newNode = newNode.NextNode; Count++; } while (newNode != null);
            return Count;
        }
        public void AddNodeAfter(Node<T> node, T value)
        {
            Node<T> newNode = new Node<T>(value);

            Node<T> nextNode = node.NextNode;
            node.NextNode = newNode;
            newNode.NextNode = nextNode;


        }

        public Node<T> FindNode(int searchValue)
        {
            var currentNode = First;

            while (currentNode != null)
            {
                if (Convert.ToInt32(currentNode.Value) == searchValue)

                    return currentNode;

                currentNode = currentNode.NextNode;
            }
            return null;
        }

        public void RemoveNode(int volue)
        {

            int currentIndex = 0;
            Node<T> currentNode = First;
            while (currentNode != null)
            {
                if (volue == currentIndex)
                {
                    var nextItem = currentNode.NextNode;
                    currentNode.PrevNode.NextNode = nextItem;

                }


                currentNode = currentNode.NextNode;
                currentIndex++;
            }

        }

        public void RemoveNode(Node<T> node)
        {
            Node<T> currentNode = First;
            if (node == First)
            {

                First = First.NextNode;
                First.PrevNode = null;

            }

            while (currentNode != null)
            {
                if (Convert.ToInt32(currentNode.Value) == Convert.ToInt32(node.Value))
                {
                    var nextItem = currentNode.NextNode;
                    currentNode.PrevNode.NextNode = nextItem;

                }
                currentNode = currentNode.NextNode;
            }

        }


    }

}
