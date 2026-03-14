using ExamBlazorProject.Data;
using Microsoft.EntityFrameworkCore;

namespace ExamBlazorProject
{
    public class StudentExamService : IStudentExamService
    {

        private readonly ApplicationDbContext _context;

        public StudentExamService(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<StudentExam> GetStudentResults(string userId)
        {
            return _context.StudentExams
                .Include(x => x.Exam)
                .ThenInclude(e => e.Subject)
                .Where(x => x.ApplicationUserId == userId)
                .ToList();
        }

        public StudentExam? GetStudentExam(int id)
        {
            return _context.StudentExams
                .Include(x => x.Exam)
                .FirstOrDefault(x => x.Id == id);
        }

        public StudentExam? GetStudentExamByUserAndExam(string userId, int examId)
        {
            return _context.StudentExams
                .FirstOrDefault(x => x.ApplicationUserId == userId && x.ExamId == examId);
        }

        public void AddStudentExam(StudentExam studentExam)
        {
            _context.StudentExams.Add(studentExam);
            _context.SaveChanges();
        }

    }
}