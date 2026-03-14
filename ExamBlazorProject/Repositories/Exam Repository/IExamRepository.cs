 
 
namespace ExamBlazorProject
{
    public interface IExamRepository : IGenericRepository<Exam>
    {
        Exam GetExamWithQuestions(int examId);
    }
}