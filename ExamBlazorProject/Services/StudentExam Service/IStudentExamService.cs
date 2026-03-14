using ExamBlazorProject;

namespace ExamBlazorProject
{
    public interface IStudentExamService
    {

        IEnumerable<StudentExam> GetStudentResults(string userId);

        StudentExam? GetStudentExam(int id);

        StudentExam? GetStudentExamByUserAndExam(string userId, int examId);

        void AddStudentExam(StudentExam studentExam);

    }
}