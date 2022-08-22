using System;
using System.Collections.Generic;

namespace BinaryTreeCSharp
{
    public class Node<T>
    {
        public T val;
        public Node<T> left;
        public Node<T> right;

        public Node(T val)
        {
            this.val = val;
            this.left = null;
            this.right = null;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var a = new Node<char>('a');
            var b = new Node<char>('b');
            var c = new Node<char>('c');
            var d = new Node<char>('d');
            var e = new Node<char>('e');
            var f = new Node<char>('f');
            a.left = b;
            a.right = c;
            b.left = d;
            b.right = e;
            c.right = f;
            //PrintDepthFirst(a);
            PrintDepthFirstRecursive(a);
        }

        public static void PrintDepthFirst(Node<char> root) {
            Stack<Node<char>> stack = new Stack<Node<char>>();
            stack.Push(root);
            while (stack.Count > 0) {
                var curr = stack.Pop();
                Console.WriteLine(curr.val);
                if (curr.right != null) {
                    stack.Push(curr.right);
                }
                if (curr.left != null) {
                    stack.Push(curr.left);
                }
            }
        }

        public static void PrintDepthFirstRecursive(Node<char> root) {
            if (root == null) {
                return;
            }
            Console.WriteLine(root.val);
            PrintDepthFirstRecursive(root.left);
            PrintDepthFirstRecursive(root.right);
        }
    }
}

