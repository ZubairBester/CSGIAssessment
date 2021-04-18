using System;

namespace API.Entities
{
    public class StudentEndOfDay
    {
        public int Id { get; set; }
        public string ClassName { get; set; }
        public string  Grade { get; set; }
        public DateTime Date { get; set; }

        public DateTime Time { get; set; }

        public string StudentsName { get; set; }
        public bool Attendency { get; set; }
    }
}