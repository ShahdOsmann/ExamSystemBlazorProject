using ExamBlazorProject.Data;
using System.ComponentModel.DataAnnotations;

namespace ExamBlazorProject
{
    public class StudentExam
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int Grade { get; set; }

        public int ExamId { get; set; }
        public Exam? Exam { get; set; }

        public string ApplicationUserId { get; set; }
        public ApplicationUser? ApplicationUser { get; set; }
    }
}
