using ExamBlazorProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExamBlazorProject
{
    public class ApplicationUserConfiguration: IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.HasMany(u => u.StudentExams)
                   .WithOne(se => se.ApplicationUser)
                   .HasForeignKey(se => se.ApplicationUserId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
