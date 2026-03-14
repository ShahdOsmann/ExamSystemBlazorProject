 using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExamBlazorProject
{
    public class ExamCofiguration : IEntityTypeConfiguration<Exam>
    {
        public void Configure(EntityTypeBuilder<Exam> builder)
        {
            builder.HasMany(e=>e.Questions)
                        .WithOne(q => q.Exam)
                        .HasForeignKey(q => q.ExamId)
                        .OnDelete(DeleteBehavior.Cascade);
    
                builder.HasMany(e => e.StudentExams)
                        .WithOne(se => se.Exam)
                        .HasForeignKey(se => se.ExamId)
                        .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
