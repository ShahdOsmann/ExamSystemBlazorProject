
using ExamBlazorProject;
using ExamBlazorProject.Data;

namespace ExamBlazorProject
{
    public class SubjectRepository : GenericRepository<Subject>, ISubjectRepository
    {
        public SubjectRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}