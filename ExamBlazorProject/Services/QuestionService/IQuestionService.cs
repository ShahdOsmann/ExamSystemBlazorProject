using ExamBlazorProject;
using System.Collections.Generic;

namespace ExamBlazorProject
{
    public interface IQuestionService
    {
        IEnumerable<Question> GetQuestionsByExam(int examId);
        Question GetQuestion(int id);
        void AddQuestion(Question question);
        void UpdateQuestion(Question question);
        void DeleteQuestion(int id);
    }
}