using System;
using System.Collections.Generic;

class Bai15
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ngo Thanh Nguyen_2415053122330");
        Dictionary<string, string> dict = new Dictionary<string, string>();

        dict.Add("hello", "xin chao");
        dict.Add("book", "quyen sach");
        dict.Add("computer", "may tinh");
        dict.Add("student", "sinh vien");
        dict.Add("teacher", "giao vien");

        Console.Write("Nhap tu tieng Anh: ");
        string word = Console.ReadLine();

        if (dict.ContainsKey(word))
        {
            Console.WriteLine("Nghia: " + dict[word]);
        }
        else
        {
            Console.WriteLine("Khong tim thay tu");
        }

        Console.ReadLine();
    }
}
