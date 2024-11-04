using System;
using System.Text;

namespace Master_C__Programming.generic
{
    internal class Lesson6
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            var stack = new Stack<int>();
            Console.WriteLine("==> Stack rỗng? " + stack.IsEmpty());

            // Thêm các phần tử
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            // Lấy phần tử đầu stack
            Console.WriteLine("==> Phần tử đầu stack: " + stack.Peek());

            // Xóa phần tử đầu stack
            stack.Pop();
            Console.WriteLine("==> Phần tử đầu stack sau khi Pop: " + stack.Peek());

            Console.WriteLine("Các phần tử còn lại trong stack:");
            stack.DisplayStack();
        }
    }

    class Stack<T> where T : IComparable<T>
    {
        private Node<T> Top { get; set; }

        // Thêm node vào stack
        public void Push(T data)
        {
            Top = new Node<T>(data, Top);
        }

        // Xóa node đầu stack
        public void Pop()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Stack is empty");

            Top = Top.Next;
        }

        // Lấy phần tử đầu stack
        public T Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Stack is empty");

            return Top.Data;
        }

        // Kiểm tra stack rỗng
        public bool IsEmpty() => Top == null;

        // Hiển thị các phần tử trong stack
        public void DisplayStack()
        {
            var current = Top;
            while (current != null)
            {
                Console.Write($" <- {current.Data}");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }

    class Node<T>
    {
        public T Data { get; }
        public Node<T> Next { get; }

        public Node(T data, Node<T> next = null)
        {
            Data = data;
            Next = next;
        }
    }
}
