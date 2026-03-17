using System;
using System.Collections.Generic;

class Bai17
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ngo Thanh Nguyen_2415053122330");
        List<int> numbers = new List<int>();
        Console.Write("Nhap so luong phan tu: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.Write("Nhap so thu " + (i + 1) + ": ");
            int x = int.Parse(Console.ReadLine());
            numbers.Add(x);
        }

        Dictionary<int, int> countDict = new Dictionary<int, int>();

        foreach (int num in numbers)
        {
            if (countDict.ContainsKey(num))
            {
                countDict[num]++;
            }
            else
            {
                countDict.Add(num, 1);
            }
        }

        int maxCount = 0;
        int result = numbers[0];

        foreach (var item in countDict)
        {
            if (item.Value > maxCount)
            {
                maxCount = item.Value;
                result = item.Key;
            }
        }

        Console.WriteLine("So xuat hien nhieu nhat: " + result);
        Console.WriteLine("So lan xuat hien: " + maxCount);

        Console.ReadLine();
    }
}