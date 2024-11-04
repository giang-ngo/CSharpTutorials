using System;
using System.Text;

namespace Master_C__Programming.generic
{
    internal class Lesson4
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            LinkedList<string> list = new LinkedList<string>();
            // chèn đầu DSLK
            list.AddFirst("One");
            list.AddFirst("Two");
            list.AddFirst("Three");
            list.AddFirst("Four");

            // chèn cuối DSLK
            list.AddLast("Five");
            list.AddLast("Six");
            Console.WriteLine("Các node trong danh sách liên kết trước khi chèn:");
            list.ShowNodes();
            // chèn sau Node x
            list.AddAfterX("TEST", "Five");
            list.AddAfterX("TEST2", "Six");
            Console.WriteLine("Các node trong danh sách liên kết sau khi chèn:");
            list.ShowNodes();

        }
    }

    class LinkedList<T>
    {
        public Node<T> First { get; private set; }
        public Node<T> Last { get; private set; }

        public LinkedList()
        {
            First = null;
            Last = null;
        }

        // thêm node vào đầu danh sách
        public void AddFirst(T data)
        {
            var newNode = new Node<T>(data);
            if (IsEmpty())
            {
                First = Last = newNode;
            }
            else
            {
                newNode.Next = First;
                First = newNode;
            }
        }

        // thêm node vào cuối danh sách
        public void AddLast(T data)
        {
            var newNode = new Node<T>(data);
            if (IsEmpty())
            {
                First = Last = newNode;
            }
            else
            {
                Last.Next = newNode;
                Last = newNode;
            }
        }

        // thêm node vào sau node x
        public void AddAfterX(T data, T x)
        {
            if (IsEmpty())
            {
                AddFirst(data);
                return;
            }

            var currentNode = First;
            while (currentNode != null)
            {
                if (currentNode.Data.Equals(x))
                {
                    var newNode = new Node<T>(data);
                    newNode.Next = currentNode.Next;
                    currentNode.Next = newNode;
                    if (currentNode == Last) Last = newNode;
                    break;
                }
                currentNode = currentNode.Next;
            }
        }

        // kiểm tra rỗng
        public bool IsEmpty()
        {
            return First == null;
        }

        // hiển thị các node trong danh sách
        public void ShowNodes()
        {
            var current = First;
            while (current != null)
            {
                Console.Write($"{current.Data} -> ");
                current = current.Next;
            }
            Console.WriteLine("null");
        }
    }

    class Node<T>
    {
        public T Data { get; }
        public Node<T> Next { get; set; }

        public Node(T data)
        {
            Data = data;
            Next = null;
        }
    }
}
