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

        int leftCount = 0, rightCount = 0;
        public bool result = false;

        public MyBinarySearchTree(T nodeData)
        {
            this.nodeData = nodeData;
            this.leftTree = null;
            this.rightTree = null;
        }
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

        public bool IfExists(T element, MyBinarySearchTree<T> node)
        {
            if (node == null)
            {
                return false;
            }
            if (node.nodeData.Equals(element))
            {
                Console.WriteLine("Found the element in BST: " + node.nodeData);
                result = true;
            }
            else
            {
                Console.WriteLine("Current element is {0} in BST", node.nodeData);
            }
            if (element.CompareTo(node.nodeData) < 0)
            {
                IfExists(element, node.leftTree);
            }
            if (element.CompareTo(node.nodeData) > 0)
            {
                IfExists(element, node.rightTree);
            }
            return result;
        }
    }
}
