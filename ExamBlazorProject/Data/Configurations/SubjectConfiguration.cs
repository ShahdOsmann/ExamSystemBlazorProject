 using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Identity.Client;

namespace ExamBlazorProject
{
    public class SubjectConfiguration : IEntityTypeConfiguration<Subject>
    {
        public void Configure(EntityTypeBuilder<Subject> builder)
        {
            builder.HasOne(s=>s.Exam)
                   .WithOne(e=>e.Subject)
                   .HasForeignKey<Subject>(s => s.ExamId) 
                   .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
