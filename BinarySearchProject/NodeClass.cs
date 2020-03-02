using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchProject
{
    class NodeClass
    {
        public void TreeClass()
        {
             public class Node
        {
            public int data;
            public Node Left;
            public Node Right;
            public void DisplayNode()
            {
                Console.WriteLine(data + " ");
            }
      
        }
        public Node root;
        public NodeClass()
        {
            root = null;
        }
        public void Insert (int i)
        {
            Node newNode = new Node();
            newNode.data = i;
            if (root == null)
                root = newNode;
            else
        }
    }
}
