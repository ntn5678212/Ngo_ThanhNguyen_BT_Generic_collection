using System;
using System.Collections.Generic;

class Bai16
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ngo Thanh Nguyen_2415053122330");
        Console.Write("Nhap chuoi: ");
        string input = Console.ReadLine();

        Dictionary<char, int> dict = new Dictionary<char, int>();

        foreach (char c in input)
        {
            if (dict.ContainsKey(c))
            {
                dict[c]++;
            }
            else
            {
                dict.Add(c, 1);
            }
        }

        Console.WriteLine("So lan xuat hien cua tung ky tu:");

        foreach (var item in dict)
        {
            Console.WriteLine(item.Key + " : " + item.Value);
        }

        Console.ReadLine();
    }
}