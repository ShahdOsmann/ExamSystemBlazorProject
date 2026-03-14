using System.ComponentModel.DataAnnotations;

namespace ExamBlazorProject
{
    public class Exam
    {
        [Key]
        public int Id { get; set; }
        public int Duration { get; set; }
        public int SubjectId { get; set; }
        public Subject? Subject { get; set; }

        public virtual ICollection<Question> Questions { get; set; } = new HashSet<Question>();

        public virtual ICollection<StudentExam> StudentExams { get; set; } = new HashSet<StudentExam>();
    }
}
