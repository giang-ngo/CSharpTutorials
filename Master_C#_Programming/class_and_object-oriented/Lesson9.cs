using System;
using System.Text;

/**
 * Tính trừu tượng
 * 
 */
namespace Master_C__Programming.class_and_object_oriented
{
    public abstract class Point
    {
        // Các thuộc tính x và y được bảo vệ, chỉ có lớp con mới có thể truy cập
        protected int _x;
        protected int _y;

        public abstract int X { get; }
        public abstract int Y { get; }

        public abstract void DoSomething();
    }

    class DerivedPoint : Point
    {
        public override int X
        {
            get { return _x + 10; }
        }

        public override int Y
        {
            get { return _y + 10; }
        }

        public override void DoSomething()
        {
            Console.WriteLine($"Doing something with point at ({X}, {Y})");
        }
    }

    abstract class Shape
    {
        public int X { get; set; } // Tọa độ X của hình
        public int Y { get; set; } // Tọa độ Y của hình

        public abstract double Area();
    }

    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle() : this(0, 0)
        {
        }

        // Constructor có tham số, khởi tạo width và height
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return Width * Height;
        }
    }

    internal class Lesson9
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Khởi tạo đối tượng hình chữ nhật với chiều rộng và chiều cao
            Rectangle rect = new Rectangle(20, 30);
            Console.WriteLine("Diện tích hình chữ nhật: " + rect.Area());

            // Tạo đối tượng DerivedPoint từ lớp Point
            DerivedPoint point = new DerivedPoint();
            point.DoSomething(); // Gọi phương thức DoSomething đã được override
        }
    }
}
