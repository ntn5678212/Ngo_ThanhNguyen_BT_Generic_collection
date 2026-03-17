using System;
using System.Collections.Generic;

    class Student
    {
        public string Name;
        public double Score;
    }

    class Bai18
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            Console.Write("Nhap so luong sinh vien: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Student s = new Student();

                Console.Write("Nhap ten: ");
                s.Name = Console.ReadLine();

                Console.Write("Nhap diem: ");
                s.Score = double.Parse(Console.ReadLine());

                students.Add(s);
            }

            double max = students[0].Score;

            foreach (Student s in students)
            {
                if (s.Score > max)
                    max = s.Score;
            }

            Console.WriteLine("Sinh vien diem cao nhat:");

            foreach (Student s in students)
            {
                if (s.Score == max)
                    Console.WriteLine(s.Name + " - " + s.Score);
            }

            Console.ReadLine();
        }
    }
