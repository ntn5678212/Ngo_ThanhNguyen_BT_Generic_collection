using System;
using System.Collections.Generic;

class bai2
{
    static void Main()
    {
        Console.WriteLine("Ngo Thanh Nguyen_2415053122330");
        List<int> numbers = new List<int>();
        int sum = 0;

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Nhap so thu " + (i + 1) + ": ");
            int n = int.Parse(Console.ReadLine());
            numbers.Add(n);
        }

        foreach (int num in numbers)
        {
            sum += num;
        }

        Console.WriteLine("Tong cac phan tu: " + sum);

        Console.ReadLine();
    }
}
