using System;
using System.Collections.Generic;
namespace bt
{
    class Student
    {
        public int Id;
        public string name;

    }
    class bai12
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
                s.name = Console.ReadLine();
                list.Add(s);
            }
            Console.Write("nhap ten sinh vien can tim: ");
            String Name = Console.ReadLine();
            bool found = false;
            foreach (Student s in list)
            {
                if (s.name == Name)
                {
                    Console.Write("da tim thay id va ten sinh vien lan luot la:" + s.Id + "-" + s.name);
                    found = true;
                }

            }
            Console.WriteLine();
            if (!found)
            {
                Console.WriteLine("khong tim thay sinh vien");
            }
            Console.WriteLine();
        }
    }


}
