namespace API.Entities
{
    public class StudentEndOfTerm
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
        public string Grade{ get; set; }
        public string ClassName { get; set; }
        public int NumberOfClassesAttendended { get; set; }
        public int NumberOfClassMissed { get; set; }
    }
}