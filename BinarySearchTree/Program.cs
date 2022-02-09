using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Binary Search Tree");

            MyBinarySearchTree<int> binaryTree = new MyBinarySearchTree<int>(56);
            while (true)
            {
                Console.WriteLine("Please choose an option:");
                Console.WriteLine("\n1. Create Binary Search Tree \n2. Display Binary Search Tree elements \n3. Check Size of BST \n4. Search a value in BST \n5. Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        binaryTree.Insert(30);
                        binaryTree.Insert(70);
                        binaryTree.Insert(22);
                        binaryTree.Insert(40);
                        binaryTree.Insert(60);
                        binaryTree.Insert(95);
                        binaryTree.Insert(11);
                        binaryTree.Insert(65);
                        binaryTree.Insert(3);
                        binaryTree.Insert(16);
                        binaryTree.Insert(63);
                        binaryTree.Insert(67);
                        break;
                    case 2:
                        binaryTree.Display();
                        break;
                    case 3:
                        binaryTree.GetSIze();
                        break;
                    case 4:
                        int search = 67;
                        bool result = binaryTree.IfExists(search, binaryTree);
                        if (result == true)
                            Console.WriteLine("{0} is present in the Binary Search Tree", search);
                        else
                            Console.WriteLine("{0} is not present in the Binary Search Tree", search);
                        break;
                    default:
                        Console.WriteLine("Please select the correct option");
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}


