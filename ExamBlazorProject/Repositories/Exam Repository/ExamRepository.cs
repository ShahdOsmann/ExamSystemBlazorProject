
using ExamBlazorProject;
using ExamBlazorProject.Data;
using Microsoft.EntityFrameworkCore;

namespace ExamBlazorProject
{
    public class ExamRepository : GenericRepository<Exam>, IExamRepository
    {
        public ExamRepository(ApplicationDbContext context) : base(context)
        {
        }

        public Exam GetExamWithQuestions(int examId)
        {
            return _dbSet
                .Include(e => e.Questions)
                    .ThenInclude(q => q.Choices)
                .FirstOrDefault(e => e.Id == examId)!;
        }
    }
}