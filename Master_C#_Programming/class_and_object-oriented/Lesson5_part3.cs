using System;


namespace Master_C__Programming.class_and_object_oriented// cùng namespace
{
    class Lesson5_part3
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Student student = new Student();
            student.DoHomework("xstk");
            student.GetInputInfo();
            student.ShowInfo();
            student.PayFee(20_000);

        }
    }
}
