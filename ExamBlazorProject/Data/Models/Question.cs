using System.ComponentModel.DataAnnotations;

namespace ExamBlazorProject
{
    public class Question
    {
        [Key]
        public int Id { get; set; }
        public string Content { get; set; }

        public int ExamId { get; set; }
        public Exam? Exam { get; set; }

        public virtual ICollection<Choice> Choices { get; set; } = new HashSet<Choice>();

    }
}
