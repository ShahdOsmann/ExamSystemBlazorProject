using ExamBlazorProject;
using System.Collections.Generic;

namespace ExamBlazorProject
{
    public interface IChoiceService
    {
        IEnumerable<Choice> GetChoicesByQuestion(int questionId);
        void AddChoice(Choice choice);
        void UpdateChoice(Choice choice);
        void DeleteChoice(int id);
    }
}