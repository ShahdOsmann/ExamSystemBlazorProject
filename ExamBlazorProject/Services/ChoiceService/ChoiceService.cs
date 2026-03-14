using ExamBlazorProject;

namespace ExamBlazorProject
{
    public class ChoiceService : IChoiceService
    {
        private readonly IGenericRepository<Choice> _choiceRepository;

        public ChoiceService(IGenericRepository<Choice> choiceRepository)
        {
            _choiceRepository = choiceRepository;
        }

        public IEnumerable<Choice> GetChoicesByQuestion(int questionId)
        {
            return _choiceRepository.GetAll()
                .Where(c => c.QuestionId == questionId)
                .ToList();
        }

        public void AddChoice(Choice choice) => _choiceRepository.Add(choice);

        public void UpdateChoice(Choice choice) => _choiceRepository.Update(choice);

        public void DeleteChoice(int id)
        {
            var c = _choiceRepository.GetById(id);
            if (c != null)
                _choiceRepository.Delete(c);
        }
    }
}