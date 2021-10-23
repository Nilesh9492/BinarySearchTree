using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Binary Search progarm");
            BinarySearch binary = new BinarySearch();
            binary.Insert(56);
            binary.Insert(30);
            binary.Insert(70);
            binary.View();

            binary.Insert(30);
            binary.Insert(70);
            binary.Insert(22);
            binary.Insert(40);
            binary.Insert(11);
            binary.Insert(3);
            binary.Insert(16);
            binary.Insert(60);
            binary.Insert(95);
            binary.Insert(65);
            binary.Insert(63);
            binary.Insert(67);
            binary.View();
            Console.WriteLine("Element " + binary.Search(63) + " is available in binary search tree");
        }
    }
}
