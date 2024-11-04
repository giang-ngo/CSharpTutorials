using System;
using System.Text;

namespace Master_C__Programming.generic
{
    internal class Lesson5
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            DoubleLinkedList<string> list = new DoubleLinkedList<string>();
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

            list.ShowNodesReverse();

            // chèn sau Node x
            list.AddAfterX("Five", "TEST");
            list.AddAfterX("Six", "TEST2");
            Console.WriteLine("Các node trong danh sách liên kết sau khi chèn:");
            list.ShowNodes();

            list.ShowNodesReverse();
        }
    }

    class DoubleLinkedList<T>
    {
        public Node<T> First { get; set; }
        public Node<T> Last { get; set; }

        public DoubleLinkedList()
        {
            First = Last = null;
        }

        // Chèn vào đầu danh sách liên kết
        public void AddFirst(T data)
        {
            Node<T> newNode = new Node<T>(data);

            if (IsEmpty())
            {
                First = Last = newNode;
            }
            else
            {
                newNode.Next = First;
                First.Prev = newNode;
                First = newNode;
            }
        }

        // Chèn vào cuối danh sách liên kết
        public void AddLast(T data)
        {
            Node<T> newNode = new Node<T>(data);

            if (IsEmpty())
            {
                First = Last = newNode;
            }
            else
            {
                Last.Next = newNode;
                newNode.Prev = Last;
                Last = newNode;
            }
        }

        // Chèn sau node x bất kỳ
        public void AddAfterX(T x, T data)
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
                    newNode.Prev = currentNode;

                    if (currentNode.Next != null)
                    {
                        currentNode.Next.Prev = newNode;
                    }
                    else
                    {
                        Last = newNode; // Cập nhật Last nếu node hiện tại là Last
                    }

                    currentNode.Next = newNode;
                    return;
                }
                currentNode = currentNode.Next;
            }
            Console.WriteLine("Không tìm thấy node cần chèn.");
        }

        // Kiểm tra danh sách rỗng
        public bool IsEmpty()
        {
            return First == null;
        }

        // Hiển thị danh sách các node
        public void ShowNodes()
        {
            var node = First;
            while (node != null)
            {
                Console.Write(node.Data);
                if (node.Next != null) Console.Write(" -> ");
                node = node.Next;
            }
            Console.WriteLine();
        }

        // Hiển thị danh sách theo thứ tự ngược lại
        public void ShowNodesReverse()
        {
            var node = Last;
            while (node != null)
            {
                Console.Write(node.Data);
                if (node.Prev != null) Console.Write(" -> ");
                node = node.Prev;
            }
            Console.WriteLine();
        }
    }

    class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }
        public Node<T> Prev { get; set; }

        public Node(T data)
        {
            Data = data;
            Next = null;
            Prev = null;
        }
    }
}
