using System.ComponentModel.DataAnnotations;

namespace ExamBlazorProject
{
    public class Subject
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public int ExamId { get; set; }
        public Exam? Exam { get; set; }
    }
}
