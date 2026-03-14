
using ExamBlazorProject;

namespace ExamBlazorProject
{
    public interface IExamService
    {
        IEnumerable<Exam> GetAllExams();
        Exam GetExam(int id);
        Exam GetExamWithQuestions(int id);
        void AddExam(Exam exam);
        void UpdateExam(Exam exam);
        void DeleteExam(int id);
        Exam GetExamWithQuestionsBySubject(int subjectId);
    }
}