 using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExamBlazorProject
{
    public class QuestionSeed : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.HasData(

                new Question
                {
                    Id = 1,
                    Content = "Which language is primarily used with .NET?",
                    ExamId = 1
                },

                new Question
                {
                    Id = 2,
                    Content = "Which keyword is used to define a class in C#?",
                    ExamId = 1
                },

                new Question
                {
                    Id = 3,
                    Content = "Which data structure works on FIFO principle?",
                    ExamId = 1
                },

                new Question
                {
                    Id = 4,
                    Content = "Which method is the entry point of a C# program?",
                    ExamId = 1
                }
            );
        }
    }
}