 using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExamBlazorProject
{
    public class ChoiceSeed : IEntityTypeConfiguration<Choice>
    {
        public void Configure(EntityTypeBuilder<Choice> builder)
        {
            builder.HasData(

                // Question 1
                new Choice { Id = 1, Content = "C#", IsCorrect = true, QuestionId = 1 },
                new Choice { Id = 2, Content = "Python", IsCorrect = false, QuestionId = 1 },
                new Choice { Id = 3, Content = "Java", IsCorrect = false, QuestionId = 1 },

                // Question 2
                new Choice { Id = 4, Content = "class", IsCorrect = true, QuestionId = 2 },
                new Choice { Id = 5, Content = "define", IsCorrect = false, QuestionId = 2 },
                new Choice { Id = 6, Content = "structural", IsCorrect = false, QuestionId = 2 },

                // Question 3
                new Choice { Id = 7, Content = "Queue", IsCorrect = true, QuestionId = 3 },
                new Choice { Id = 8, Content = "Stack", IsCorrect = false, QuestionId = 3 },
                new Choice { Id = 9, Content = "Tree", IsCorrect = false, QuestionId = 3 },

                // Question 4
                new Choice { Id = 10, Content = "Main()", IsCorrect = true, QuestionId = 4 },
                new Choice { Id = 11, Content = "Start()", IsCorrect = false, QuestionId = 4 },
                new Choice { Id = 12, Content = "Run()", IsCorrect = false, QuestionId = 4 }

            );
        }
    }
}