
using ExamBlazorProject;

namespace ExamBlazorProject
{
    public interface ISubjectService
    {
        IEnumerable<Subject> GetAllSubjects();
        Subject GetSubject(int id);
        void AddSubject(Subject subject);
        void UpdateSubject(Subject subject);
        void DeleteSubject(int id);
    }
}