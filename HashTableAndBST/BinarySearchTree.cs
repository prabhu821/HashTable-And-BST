using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableAndBST
{
    public class BinarySearchTree
    {
        public Node root;
        public BinarySearchTree()
        {
            root = null;
        }
        public Node ReturnRoot()
        {
            return root;
        }
        public void Insert(int id)
        {
            Node node = new Node(id);
            if (root == null)
                root = node;
            else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if (id < current.item)
                    {
                        current = current.leftCount;
                        if (current == null)
                        {
                            parent.leftCount = node;
                            return;
                        }
                    }
                    else
                    {
                        current = current.rightCount;
                        if (current == null)
                        {
                            parent.rightCount = node;
                            return;
                        }
                    }
                }
            }
        }

        public void Display(Node root)
        {
            if (root != null)
            {
                Console.WriteLine(root.item + " | ");
                Display(root.leftCount);
                Display(root.rightCount);
            }
        }

        //SIZE
        public int size()
        {
            return size(root);
        }
        public int size(Node node)
        {
            if (node == null)
            {
                return 0;
            }
            else
            {
                return (size(node.leftCount) + 1 + size(node.rightCount));
            }
        }

        public Node Search(int value)
        {
            Node result = Search(root, value);
            if (result != null)
            {
                Console.WriteLine("Found: " + result.item);
            }
            else
            {
                Console.WriteLine("Not found.");
            }
            return result;
        }

        private Node Search(Node node, int value)
        {
            if (node == null || node.item == value)
            {
                return node;
            }

            if (value < node.item)
            {
                return Search(node.leftCount, value);
            }
            else
            {
                return Search(node.rightCount, value);
            }
        }

    }
}
