using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ExamBlazorProject.Data
{
    public class ApplicationUser:IdentityUser
    { 
        public string FName { get; set; }= string.Empty;
        public string? LName { get; set; }

        public virtual ICollection<StudentExam> StudentExams { get; set; } = new HashSet<StudentExam>();
    }
}
