using System;
using System.Collections.Generic;

class Bai6
{
    static void Main()
    {
        Console.WriteLine("Ngo Thanh Nguyen_2415053122330");
        List<string> list = new List<string>();

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Nhap chuoi thu " + (i + 1) + ": ");
            string s = Console.ReadLine();
            list.Add(s);
        }

        Console.Write("Nhap chuoi can kiem tra: ");
        string check = Console.ReadLine();

        if (list.Contains(check))
        {
            Console.WriteLine("Chuoi ton tai trong danh sach");
        }
        else
        {
            Console.WriteLine("Chuoi khong ton tai trong danh sach");
        }

        Console.ReadLine();
    }
}
