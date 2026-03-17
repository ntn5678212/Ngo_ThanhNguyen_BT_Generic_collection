using System;
using System.Collections.Generic;

class Student
{
    public int Id;
    public string Name;
}

class Bai11
{
    static void Main()
    {
        Console.WriteLine("Ngo Thanh Nguyen_2415053122330");
        List<Student> students = new List<Student>();

        for (int i = 0; i < 3; i++)
        {
            Student s = new Student();

            Console.Write("Nhap Id sinh vien: ");
            s.Id = int.Parse(Console.ReadLine());

            Console.Write("Nhap ten sinh vien: ");
            s.Name = Console.ReadLine();

            students.Add(s);
        }

        Console.WriteLine("Danh sach sinh vien:");

        foreach (Student s in students)
        {
            Console.WriteLine("Id: " + s.Id + " - Name: " + s.Name);
        }

        Console.ReadLine();
    }
}