
using ExamBlazorProject;
using Microsoft.EntityFrameworkCore;

namespace ExamBlazorProject
{
    public class SubjectService : ISubjectService
    {
        private readonly ISubjectRepository _subjectRepository;

        public SubjectService(ISubjectRepository subjectRepository)
        {
            _subjectRepository = subjectRepository;
        }

        public IEnumerable<Subject> GetAllSubjects() => _subjectRepository.GetAll().ToList();

        public Subject GetSubject(int id) => _subjectRepository.GetById(id);

        public void AddSubject(Subject subject) => _subjectRepository.Add(subject);

        public void UpdateSubject(Subject subject) => _subjectRepository.Update(subject);

        public void DeleteSubject(int id)
        {
            var subject = _subjectRepository.GetById(id);
            if (subject != null)
                _subjectRepository.Delete(subject);
        }
    }
}