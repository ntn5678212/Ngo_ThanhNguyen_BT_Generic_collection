using System;
using System.Collections.Generic;

class Bai9
{
    static void Main()
    {
        Console.WriteLine("Ngo Thanh Nguyen_2415053122330");
        List<int> numbers = new List<int>();

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Nhap so thu " + (i + 1) + ": ");
            int n = int.Parse(Console.ReadLine());
            numbers.Add(n);
        }

        List<int> uniqueList = new List<int>();

        foreach (int num in numbers)
        {
            if (!uniqueList.Contains(num))
            {
                uniqueList.Add(num);
            }
        }

        Console.WriteLine("Danh sach khong trung lap:");

        foreach (int num in uniqueList)
        {
            Console.Write(num + " ");
        }

        Console.ReadLine();
    }
}
