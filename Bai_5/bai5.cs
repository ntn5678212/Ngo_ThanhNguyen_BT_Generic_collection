using System;
using System.Collections.Generic;

class Bai5
{
    static void Main()
    {
        Console.WriteLine("Ngo Thanh Nguyen_2415053122330");
        List<string> students = new List<string>();

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Nhap ten sinh vien thu " + (i + 1) + ": ");
            string name = Console.ReadLine();
            students.Add(name);
        }

        Console.Write("Nhap ten sinh vien can xoa: ");
        string removeName = Console.ReadLine();

        students.Remove(removeName);

        Console.WriteLine("Danh sach sinh vien sau khi xoa:");

        foreach (string s in students)
        {
            Console.WriteLine(s);
        }

        Console.ReadLine();
    }
}
