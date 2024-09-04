namespace StudentCRUD.Core.Api.Models.Students
{
    public class Student
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public StudentType StudentType { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public DateTimeOffset UpdateDate { get; set;}
    }
}
