using System;
using System.Collections.Generic;

class bai4
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

        int count = 0;

        foreach (int num in numbers)
        {
            if (num % 2 == 0)
            {
                count++;
            }
        }

        Console.WriteLine("So luong so chan: " + count);

        Console.ReadLine();
    }
}