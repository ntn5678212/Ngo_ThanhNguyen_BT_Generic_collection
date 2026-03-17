using System;
using System.Collections.Generic;

class Bai8
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

        numbers.Reverse();

        Console.WriteLine("Danh sach sau khi dao nguoc:");

        foreach (int num in numbers)
        {
            Console.Write(num+" ");
        }

        Console.ReadLine();
    }
}