using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    public class BinarySearchTree
    {
        TreeNode root;
        int treeSize = 0;
        /// <summary>
        /// First value will be set to root 
        /// else the data will be added to right or left side of root 
        /// </summary>
        /// <param name="data">The data.</param>
        public void Insert(int data)
        {
            if (root == null)
            {
                root = new TreeNode(data);
                treeSize++;
            }
            else
            {
                root.Insert(data);
                treeSize++;
            }
        }
        /// <summary>
        /// Returns the size of the tree
        /// </summary>
        /// <returns></returns>
        public int Size()
        {
            if (root == null)
            {
                Console.WriteLine("Binary Search Tree is Empty");
            }
            return treeSize;
        }
        /// <summary>
        /// Searches the specific data in the tree 
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns></returns>
        public int Search(int data)
        {
            if (root == null)
            {
                Console.WriteLine("Binary Search Tree is Empty");
                return 0;
            }
            else
            {
                return root.Search(data);
            }
        }
        //Displays the items of tree
        public void Display()
        {
            if (root == null)
            {
                Console.WriteLine("Binary Search Tree is Empty");
            }
            else
            {
                root.InOrderTraversal();
            }
        }

    }
}