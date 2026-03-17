using System;
using System.Collections.Generic;
using System.Text;

namespace BT_Generic_collection
{
    class students
    {
        public int id;
        public string name;
    }
    class bai14
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
            Console.WriteLine("nhap id sinh vien can xoa");
            int id=int.Parse(Console.ReadLine());
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Id == id)
                {
                    list.RemoveAt(i);
                    break;
                }
            }

            Console.WriteLine("Danh sach sau khi xoa:");

            foreach (Student s in list)
            {
                Console.WriteLine("id và ten sinh vien lan luot la : "+s.Id + " - " + s.Name);
            }

            Console.ReadLine();

        }
    }
}
