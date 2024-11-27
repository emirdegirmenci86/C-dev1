namespace StudentManagementSystem
{
    public class Student : Person
    {
        public override void ShowInfo()
        {
            Console.WriteLine($"Öğrenci: {Name}, ID: {ID}");
        }
    }
}
