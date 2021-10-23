using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    class TreeNode
    {
        public int data;
        public TreeNode leftNode;
        public TreeNode rightNode;
        public TreeNode(int data)
        {
            this.data = data;
            leftNode = null;
            rightNode = null;
        }
        public void Insert(int data)
        {
            int rootData = this.data;
            if (data >= rootData)
            {
                if (rightNode == null)
                {
                    rightNode = new TreeNode(data);
                }
                else
                {
                    rightNode.Insert(data);
                }
            }
            else
            {
                if (leftNode == null)
                {
                    leftNode = new TreeNode(data);
                }
                else
                {
                    leftNode.Insert(data);
                }
            }
        }
        
        public void OrderTraversal()
        {
            if (leftNode != null)
            {
                leftNode.OrderTraversal();
            }
            Console.Write(data + " ");
            if (rightNode != null)
            {
                rightNode.OrderTraversal();
            }
        }
        public int Search(int data)
        {
            TreeNode currentNode = this;
            while (currentNode != null)
            {
                if (currentNode.data == data)
                {
                    return currentNode.data;
                }
                else
                {
                    if (data > currentNode.data)
                    {
                        currentNode = currentNode.rightNode;
                    }
                    else
                    {
                        currentNode = currentNode.leftNode;
                    }
                }
            }
            return 0;
        }
    }
}
