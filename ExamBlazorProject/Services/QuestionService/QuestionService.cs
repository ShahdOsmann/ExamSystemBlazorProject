using ExamBlazorProject;

namespace ExamBlazorProject
{
    public class QuestionService : IQuestionService
    {
        private readonly IGenericRepository<Question> _questionRepository;

        public QuestionService(IGenericRepository<Question> questionRepository)
        {
            _questionRepository = questionRepository;
        }

        public IEnumerable<Question> GetQuestionsByExam(int examId)
        {
            return _questionRepository.GetAll()
                .Where(q => q.ExamId == examId)
                .ToList();
        }

        public Question GetQuestion(int id) => _questionRepository.GetById(id);

        public void AddQuestion(Question question) => _questionRepository.Add(question);

        public void UpdateQuestion(Question question) => _questionRepository.Update(question);

        public void DeleteQuestion(int id)
        {
            var q = _questionRepository.GetById(id);
            if (q != null)
                _questionRepository.Delete(q);
        }
    }
}