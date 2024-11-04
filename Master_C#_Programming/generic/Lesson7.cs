using System;

namespace Master_C__Programming.Generic
{
    internal class Lesson7
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Queue<int> queue = new Queue<int>();

            // thêm vào queue
            queue.Push(1);
            queue.Push(2);
            queue.Push(3);
            queue.Push(4);
            queue.Push(5);


            Console.WriteLine("Các phần tử trong hàng đợi:");
            queue.Elements();

            // lấy phần tử đầu
            Console.WriteLine($"Phần tử đầu hàng đợi: {queue.Peek()}");

            // lấy phần tử cuối
            Console.WriteLine($"Phần tử cuối hàng đợi: {queue.Back()}");

            // xóa bỏ phần tử đầu hàng đợi
            queue.Pop();
            Console.WriteLine($"Phần tử đầu hàng đợi: {queue.Peek()}");

            // hiển thị các phần tử trong queue
            queue.Push(100);
            Console.WriteLine("Các phần tử trong hàng đợi:");
            queue.Elements();
        }
    }

    class Queue<T>
    {
        private Node<T> _first;
        private Node<T> _last;

        public Queue()
        {
            _first = null;
            _last = null;
        }

        // Thêm node vào hàng đợi
        public void Push(T data)
        {
            var node = new Node<T>(data);
            if (IsEmpty())
            {
                _first = _last = node;
            }
            else
            {
                _last.Next = node;
                _last = node;
            }
        }

        // Xóa node khỏi hàng đợi
        public void Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty");
            }
            _first = _first.Next;
        }

        // Lấy node đầu tiên nhưng không xóa
        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty");
            }
            return _first.Data;
        }

        // Lấy node cuối nhưng không xóa
        public T Back()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty");
            }
            return _last.Data;
        }

        // Kiểm tra rỗng
        public bool IsEmpty() => _first == null;

        // Liệt kê các phần tử trong hàng đợi
        public void Elements()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty");
                return;
            }

            var current = _first;
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
        public T Data { get; set; }
        public Node<T> Next { get; set; }

        public Node(T data)
        {
            Data = data;
            Next = null;
        }
    }
}
