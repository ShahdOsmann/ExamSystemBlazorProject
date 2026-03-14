
using ExamBlazorProject;
using Microsoft.EntityFrameworkCore;

namespace ExamBlazorProject
{
    public class ExamService : IExamService
    {
        private readonly IExamRepository _examRepository;

        public ExamService(IExamRepository examRepository)
        {
            _examRepository = examRepository;
        }

        public IEnumerable<Exam> GetAllExams() => _examRepository.GetAll().ToList();

        public Exam GetExam(int id) => _examRepository.GetById(id);

        public Exam GetExamWithQuestions(int id) => _examRepository.GetExamWithQuestions(id);

        public void AddExam(Exam exam) => _examRepository.Add(exam);

        public void UpdateExam(Exam exam) => _examRepository.Update(exam);

        public void DeleteExam(int id)
        {
            var exam = _examRepository.GetById(id);
            if (exam != null)
                _examRepository.Delete(exam);
        }
        // New method
        public Exam GetExamWithQuestionsBySubject(int subjectId)
        {
            return _examRepository.GetAll()
                .Include(e => e.Subject)
                .Include(e => e.Questions)
                    .ThenInclude(q => q.Choices)
                .FirstOrDefault(e => e.SubjectId == subjectId);
        }
    }
}