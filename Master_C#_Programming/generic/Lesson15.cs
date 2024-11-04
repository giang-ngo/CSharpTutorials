using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_C__Programming.generic
{
    internal class Lesson15
    {
        // tìm hiểu lớp Hashtable
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Hashtable ht = new Hashtable();
            ht.Add("Monday", "Thứ Hai");
            ht.Add("Tuesday", "Thứ Ba");
            ht.Add("Friday", "Thứ Sáu");
            ht.Add("Sunday", "Chủ Nhật");
            ht.Add("Saturday", "Thứ Bảy");
            Console.WriteLine("==> Số lượng phần tử của bảng băm: " + ht.Count);
            ShowElements(ht);

            // xóa
            Console.WriteLine("==> 'Thứ Bảy' có tồn tại trong ht không? " + ht.ContainsValue("Thứ Bảy"));
            Console.WriteLine("==> Số lượng phần tử của bảng băm sau xóa: " + ht.Count);
            ShowElements(ht);

            // ht.Clear();
            // lấy phần tử qua key và tên bảng băm
            var value = ht["Sunday"];
            Console.WriteLine("==> Phần value của key 'Sunday' là: " + value);

            // lấy danh sách key:
            Console.WriteLine("==> Danh sách các key: ");
            foreach (var item in ht.Keys)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            // lấy danh sách value:
            Console.WriteLine("==> Danh sách các value: ");
            foreach (var item in ht.Values)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        private static void ShowElements(Hashtable ht)
        {
            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine(item.Key + " - " + item.Value);
            }
        }
    }
}
