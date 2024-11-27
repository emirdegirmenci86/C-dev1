using System;
using System.Collections.Generic;

namespace StudentManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            List<Instructor> instructors = new List<Instructor>();
            List<Course> courses = new List<Course>();

            Console.WriteLine("=== Öğrenci ve Ders Yönetim Sistemi ===");

            while (true)
            {
                Console.WriteLine("\nYapmak istediğiniz işlemi seçin:");
                Console.WriteLine("1. Öğrenci Ekle");
                Console.WriteLine("2. Öğretim Görevlisi Ekle");
                Console.WriteLine("3. Ders Ekle");
                Console.WriteLine("4. Derse Öğrenci Kaydet");
                Console.WriteLine("5. Ders Bilgilerini Görüntüle");
                Console.WriteLine("6. Çıkış");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        var student = new Student();
                        Console.Write("Öğrenci Adı: ");
                        student.Name = Console.ReadLine();
                        Console.Write("Öğrenci ID: ");
                        student.ID = Console.ReadLine();
                        students.Add(student);
                        Console.WriteLine("Öğrenci başarıyla eklendi.");
                        break;

                    case "2":
                        var instructor = new Instructor();
                        Console.Write("Öğretim Görevlisi Adı: ");
                        instructor.Name = Console.ReadLine();
                        Console.Write("Öğretim Görevlisi ID: ");
                        instructor.ID = Console.ReadLine();
                        Console.Write("Bölüm: ");
                        instructor.Department = Console.ReadLine();
                        instructors.Add(instructor);
                        Console.WriteLine("Öğretim Görevlisi başarıyla eklendi.");
                        break;

                    case "3":
                        var course = new Course();
                        Console.Write("Ders Adı: ");
                        course.CourseName = Console.ReadLine();
                        Console.Write("Ders Kredi: ");
                        course.Credits = int.Parse(Console.ReadLine());
                        Console.WriteLine("Dersi veren öğretim görevlisinin ID'sini girin:");
                        foreach (var inst in instructors)
                        {
                            Console.WriteLine($"- {inst.Name} (ID: {inst.ID})");
                        }
                        string instId = Console.ReadLine();
                        course.Instructor = instructors.Find(i => i.ID == instId);
                        courses.Add(course);
                        Console.WriteLine("Ders başarıyla eklendi.");
                        break;

                    case "4":
                        Console.WriteLine("Hangi derse öğrenci kaydedilecek? Ders ID'sini girin:");
                        for (int i = 0; i < courses.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {courses[i].CourseName}");
                        }
                        int courseIndex = int.Parse(Console.ReadLine()) - 1;

                        Console.WriteLine("Hangi öğrenci kaydedilecek? Öğrenci ID'sini girin:");
                        foreach (var stu in students)
                        {
                            Console.WriteLine($"- {stu.Name} (ID: {stu.ID})");
                        }
                        string stuId = Console.ReadLine();
                        var selectedStudent = students.Find(s => s.ID == stuId);

                        courses[courseIndex].RegisteredStudents.Add(selectedStudent);
                        Console.WriteLine("Öğrenci başarıyla derse kaydedildi.");
                        break;

                    case "5":
                        foreach (var c in courses)
                        {
                            c.ShowCourseDetails();
                        }
                        break;

                    case "6":
                        Console.WriteLine("Çıkış yapılıyor...");
                        return;

                    default:
                        Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyin.");
                        break;
                }
            }
        }
    }
}
