using System;
using System.Collections.Generic;
using System.Text;

namespace BT_Generic_collection
{
    class Student
    {
        public int id;
        public string name;
    }
    class bai13
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ngo Thanh Nguyen_2415053122330");
            List<Student> list = new List<Student>();
            for (int i = 0; i < 3; i++)
            {
                Student s = new Student();
                Console.Write("nhap id sinh vien thu " + (i + 1) + ":");
                s.Id = int.Parse(Console.ReadLine());
                Console.Write("nhap ten sinh vien " + (i + 1) + ": ");
                s.Name = Console.ReadLine();
                list.Add(s);
            }
            int count = list.Count;

            Console.WriteLine("So luong sinh vien: " + count);

            Console.ReadLine();
        }
    }
}
