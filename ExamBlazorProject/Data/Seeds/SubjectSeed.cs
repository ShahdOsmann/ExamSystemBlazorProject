 using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExamBlazorProject
{
    public class SubjectSeed : IEntityTypeConfiguration<Subject>
    {
        public void Configure(EntityTypeBuilder<Subject> builder)
        {
            builder.HasData(
                new Subject
                {
                    Id = 1,
                    Name = "Mathematics",
                    ExamId = 1
                },
                new Subject
                {
                    Id = 2,
                    Name = "Physics",
                    ExamId = 2
                }
            );
        }
    }
}