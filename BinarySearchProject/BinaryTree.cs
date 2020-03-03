using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchProject
{
    public class BinaryTree
    {

        public NodeClass root;
        public BinaryTree()
        {
            root = null;
        }
        public void Insert(int i)
        {
            NodeClass newNode = new NodeClass();
            newNode.Data = i;
            if (root == null)
            {
                root = newNode;
            }
            else
            {
                NodeClass current = root;
                NodeClass parent;
                while (true)
                {
                    parent = current;
                    if (i > current.Data)
                    {
                        current = current.Right;
                        if (current == null)
                        {
                            parent.Left = newNode;
                            break;
                        }
                    }
                    else
                    {
                        current = current.Left;
                        if (current == null) 
                        {
                            parent.Right = newNode;
                            break;
                        }
                    }
                    
                }
            }
        }
    }
    
}
  
