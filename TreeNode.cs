﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    public class TreeNode
    {
        public int data;
        public TreeNode leftNode;
        public TreeNode rightNode;
        /// <summary>
        /// Constructor  <see cref="TreeNode"/> class.
        /// </summary>
        /// <param name="data">The data.</param>
        public TreeNode(int data)
        {
            this.data = data;
            leftNode = null;
            rightNode = null;
        }
        /// <summary>
        /// Inserts the data to the tree 
        /// </summary>
        /// <param name="data">The data.</param>
        public void Insert(int data)
        {
            int rootData = this.data;
            //If the received value is greater then root data, data will be 
            //Added to the right side of tree else data is added to left side of tree
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
        /// <summary>
        /// Searches the specified data if found returns number searched back or else
        /// return 0
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns></returns>
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
        //Displaying data as leftNode then  rootNode then  rightNode
        public void InOrderTraversal()
        {
            if (leftNode != null)
            {
                leftNode.InOrderTraversal();
            }
            Console.Write(data + "\n");
            if (rightNode != null)
            {
                rightNode.InOrderTraversal();
            }
        }
    }
}
