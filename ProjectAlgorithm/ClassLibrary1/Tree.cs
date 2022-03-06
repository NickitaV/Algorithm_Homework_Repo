using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAlgorithm
{
    public enum Side
    {
        Left,
        Right
    }
    public class Tree<T>
    {

        public T Value { get; set; }
        public Tree<T> Right { get; set; }
        public Tree<T> Left { get; set; }
        public Tree<T> Parent { get; set; }

        public Tree(T value)
        {
            Value = value;

        }


        public bool TreeOb(T obj)
        {
            Tree<T> node = obj as Tree<T>;

            if (node == null)
                return false;

            return Convert.ToInt32(node.Value) == Convert.ToInt32(Value);

        }




    }
}