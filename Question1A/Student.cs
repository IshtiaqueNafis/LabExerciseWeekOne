namespace Lab_Exercise_1A
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public Student()
        {
            Id = 0;
            Name = "Unknown";
            Address = "Unknown";
            
        }

        public Student(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Student(int id, string name, string address)
        {
            Id = id;
            Name = name;
            Address = address;
        }

        public override string ToString() => $"id:{Id} Name:{Name} Address{Address}";
    }
}