using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectAlgorithm
{
    internal interface ILinkedList<T>
    {
        int GetCount(); // возвращает количество элементов в списке
        void AddNode(T value);  // добавляет новый элемент списка
        void AddNodeAfter(Node<T> node, T value); // добавляет новый элемент списка после определённого элемента
        void RemoveNode(int index); // удаляет элемент по порядковому номеру
        void RemoveNode(Node<T> node); // удаляет указанный элемент
        Node<T> FindNode(int searchValue); // ищет элемент по его значению
    }

}
