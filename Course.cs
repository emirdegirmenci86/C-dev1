using System;
using System.Collections.Generic;

namespace StudentManagementSystem
{
    public class Course
    {
        public string CourseName { get; set; } = string.Empty;
        public int Credits { get; set; }
        public Instructor Instructor { get; set; } = new Instructor();
        public List<Student> RegisteredStudents { get; set; } = new List<Student>();

        public void ShowCourseDetails()
        {
            Console.WriteLine($"\nDers Adı: {CourseName}");
            Console.WriteLine($"Kredi: {Credits}");
            Console.WriteLine($"Öğretim Görevlisi: {Instructor.Name}");
            Console.WriteLine("Kayıtlı Öğrenciler:");
            if (RegisteredStudents.Count == 0)
            {
                Console.WriteLine("- Henüz kayıtlı öğrenci yok.");
            }
            else
            {
                foreach (var student in RegisteredStudents)
                {
                    Console.WriteLine($"- {student.Name} (ID: {student.ID})");
                }
            }
        }
    }
}
