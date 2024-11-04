using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_C__Programming.generic
{
    internal class Lesson12
    {
        // tìm hiểu lớp Dictionary<TKey, TValue> của namespace System.Collections.Generic;
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Dictionary<string, int> dic = new Dictionary<string, int>();
            dic.Add("One", 1); // key không được phép null
            dic.Add("Two", 2);
            dic.Add("Three", 3);
            dic.Add("Four", 4);

            // kiểm tra trước khi thêm cặp key-value
            if (!dic.ContainsKey("One"))
            {
                dic.Add("One", 100); // không thêm 1 key 2 lần vào dictionary
            }
            Console.WriteLine($"==> Số phần của dic: {dic.Count}");
            var value = dic["One"];
            Console.WriteLine($"==> Giá trị liên kết với key 'One': {value}");

            // lấy danh sách key và value có trong từ điển:
            var keys = dic.Keys;
            var values = dic.Values;
            Console.WriteLine("==> Danh sách các keys trong từ điển dic: ");
            foreach (var item in keys)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("==> Danh sách các values trong từ điển dic: ");
            foreach (var item in values)
            {
                Console.WriteLine(item);
            }

            // xóa cặp key-value
            var key = "One";
            if (dic.ContainsKey(key))
            {
                dic.Remove(key);
            }
            //value = dic["One"];
            var ret = dic.TryGetValue("One", out int tValue);
            if (ret)
            {
                Console.WriteLine("==> Tìm thấy giá trị liên kết với key 'One'");
                Console.WriteLine($"==> Giá trị liên kết với key 'One': {tValue}");
            }
            else
            {
                Console.WriteLine("==> Không tồn tại key nào có giá trị là 'One'.");
            }
        }
    }
}
