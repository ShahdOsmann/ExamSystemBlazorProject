using System.ComponentModel.DataAnnotations;

namespace ExamBlazorProject
{
    public class Choice
    {
        [Key]
        public int Id { get; set; }
        public string Content { get; set; }
        public bool IsCorrect { get; set; }

        public int QuestionId { get; set; }
        public Question? Question { get; set; }
    }
}
