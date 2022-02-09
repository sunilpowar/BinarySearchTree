using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class MyBinarySearchTree<T> where T : IComparable<T>
    {
        public T nodeData { get; set; }
        public MyBinarySearchTree<T> leftTree { get; set; }
        public MyBinarySearchTree<T> rightTree { get; set; }
        public MyBinarySearchTree(T nodeData)
        {
            this.nodeData = nodeData;
            this.leftTree = null;
            this.rightTree = null;
        }
        int leftCount = 0, rightCount = 0;

        public void Insert(T data)
        {
            T currentNodeValue = nodeData;
            if ((data.CompareTo(currentNodeValue)) < 0)
            {
                if (this.leftTree == null)
                {
                    this.leftTree = new MyBinarySearchTree<T>(data);
                    leftCount++;
                }
                else
                {
                    this.leftTree.Insert(data);
                    leftCount++;
                }
            }
            else
            {
                if (this.rightTree == null)
                {
                    this.rightTree = new MyBinarySearchTree<T>(data);
                    rightCount++;
                }
                else
                {
                    this.rightTree.Insert(data);
                    rightCount++;
                }
            }
        }

        public void Display()
        {
            if (this.leftTree != null)
            {
                this.leftTree.Display();
            }
            Console.Write(this.nodeData.ToString() + " ");
            if (this.rightTree != null)
            {
                this.rightTree.Display();
            }
        }

        public void GetSIze()
        {
            Console.WriteLine("\nSize of Binary Tree is: " + (this.leftCount + this.rightCount + 1));
        }
    }
}
