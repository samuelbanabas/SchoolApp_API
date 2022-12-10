using System.Diagnostics.Contracts;

namespace SchoolApp_AppAPI.Models
{
    public class Tutor
    {
        public int Id { get; set; }
        public string? Name { get; set;  }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public IList<Course>? Courses { get; set; }

    }
}