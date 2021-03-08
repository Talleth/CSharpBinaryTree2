using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject
{
    public class Program
    {
        public static void Main(string[] pArguments)
        {
            BinaryTree binaryTree = new BinaryTree();

            // Root of tree
            binaryTree.Root = new BinaryTree.Node("0100");

            // Left side of tree
            binaryTree.Root.Left        = new BinaryTree.Node("0060");
            binaryTree.Root.Left.Left   = new BinaryTree.Node("0050");
            binaryTree.Root.Left.Right  = new BinaryTree.Node("0067");

            // Right side of tree
            binaryTree.Root.Right       = new BinaryTree.Node("0110");
            binaryTree.Root.Right.Left  = new BinaryTree.Node("0109");
            binaryTree.Root.Right.Right = new BinaryTree.Node("0111");

            Console.Write("Print InOrder\t- ");
            Program.PrintInOrder(binaryTree.Root);
            Console.WriteLine("");
            Console.Write("Print PreOrder\t- ");
            Program.PrintPreOrder(binaryTree.Root);
            Console.WriteLine("");
            Console.Write("Print PostOrder\t- ");
            Program.PrintPostOrder(binaryTree.Root);
            Console.WriteLine("");
        }

        public static void PrintInOrder(BinaryTree.Node root)
        {
            if (root != null)
            {
                Program.PrintInOrder(root.Left);
                Console.Write(root.Data + " ");
                Program.PrintInOrder(root.Right);
            }
        }

        public static void PrintPreOrder(BinaryTree.Node root)
        {
            if (root != null)
            {
                Console.Write(root.Data + " ");
                Program.PrintPreOrder(root.Left);
                Program.PrintPreOrder(root.Right);
            }
        }

        public static void PrintPostOrder(BinaryTree.Node root)
        {
            if (root != null)
            {
                Program.PrintPostOrder(root.Left);
                Program.PrintPostOrder(root.Right);
                Console.Write(root.Data + " ");
            }
        }
    }

    public class BinaryTree
    {
        private Node m_root;

        public BinaryTree()
        {
        }

        public Node Root
        {
            get { return this.m_root; }
            set { this.m_root = value; }
        }

        public class Node
        {
            private Node m_right;
            private Node m_left;
            private string m_data;

            public Node(string data)
            {
                this.m_data = data;
                this.m_right = null;
                this.m_left = null;
            }

            public Node Right
            {
                get { return this.m_right; }
                set { this.m_right = value; }
            }

            public Node Left
            {
                get { return this.m_left; }
                set { this.m_left = value; }
            }

            public string Data
            {
                get { return this.m_data; }
                set { this.m_data = value; }
            }
        }
    }
}
