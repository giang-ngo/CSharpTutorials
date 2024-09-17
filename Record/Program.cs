public class Record
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        //// tạo đối tượng record Person
        //Person person = new("Hương", "Nguyễn");
        //Console.WriteLine(person);
        //// kết quả: Person { FirstName = Hương, LastName = Nguyễn }

        //// tạo record của Student
        //Student student = new Student
        //{
        //    Id = "ST1001",
        //    FullName = "Lê Hồng Phong",
        //    Age = 20,
        //};
        //// kết quả: Student { Id = ST1001, FullName = Lê Hồng Phong, Age = 20 }
        //Console.WriteLine(student);
        // thử thay đổi giá trị của FirstName
        //person.FirstName = "Khánh";// error
        // thử thay đổi giá trị của mã sinh viên
        //student.Id = "ST1005";// error

        //Person person = new Person("Hương", "Phạm", new string[] { "0972 032 178" });
        //Person other = person with { FirstName = "Long" };
        //Console.WriteLine(person);
        //Console.WriteLine(other);
        //Console.WriteLine(person.PhoneNumbers[0]);

        //// thay đồi giá trị của số điện thoại
        //other.PhoneNumbers[0] = "0359 259 315";
        //Console.WriteLine(person.PhoneNumbers[0]);
        //Console.WriteLine(other.PhoneNumbers[0]);

        //DailTemperature[] data = new DailTemperature[]
        //{
        //    new DailTemperature(30,11),
        //    new DailTemperature(32,12),
        //    new DailTemperature(12,90),
        //    new DailTemperature(35,20),
        //    new DailTemperature(15,71),
        //};
        //ShowTempData(data);

        DailTemperature todayTemp = new DailTemperature(30, 12);
        var otherTemp = todayTemp with { };
        var nextDayTemp = todayTemp with { HighTemp = 35 };
        Console.WriteLine(todayTemp);
        Console.WriteLine(nextDayTemp);
        Console.WriteLine(todayTemp == nextDayTemp);
        Console.WriteLine(todayTemp == otherTemp);
    }

    private static void ShowTempData(DailTemperature[] data)
    {
        foreach (var item in data)
        {
            Console.WriteLine(item);
        }
    }

    public record class Person(string FirstName, string LastName, string[] PhoneNumbers);

}

public record Person(string FirstName, string LastName);

public record Student
{
    public string Id { get; init; } = default!;
    public string FullName { get; init; } = default!;
    public int Age { get; init; } = default!;

}

public readonly record struct DailTemperature(double HighTemp, double LowTemp)
{
    public double Mean => (LowTemp + HighTemp) / 2;
}
