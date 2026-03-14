 using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExamBlazorProject
{
    public class ExamSeed : IEntityTypeConfiguration<Exam>
    {
        public void Configure(EntityTypeBuilder<Exam> builder)
        {
            builder.HasData(
                new Exam
                {
                    Id = 1,
                    Duration = 5,
                    SubjectId = 1
                },
                new Exam
                {
                    Id = 2,
                    Duration = 5,
                    SubjectId = 2
                }
            );
        }
    }
}