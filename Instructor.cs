namespace StudentManagementSystem
{
    public class Instructor : Person
    {
        public string Department { get; set; } = string.Empty;

        public override void ShowInfo()
        {
            Console.WriteLine($"Öğretim Görevlisi: {Name}, ID: {ID}, Bölüm: {Department}");
        }
    }
}
