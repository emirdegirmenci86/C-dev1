using System;

namespace StudentManagementSystem
{
    public abstract class Person
    {
        public string Name { get; set; } = string.Empty;
        public string ID { get; set; } = string.Empty;

        public abstract void ShowInfo(); // Polymorphism
    }
}
