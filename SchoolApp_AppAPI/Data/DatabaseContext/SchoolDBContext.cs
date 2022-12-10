using Microsoft.EntityFrameworkCore;
using SchoolApp_AppAPI.Models;

namespace SchoolApp_AppAPI.Data.DatabaseContext
{
    public class SchoolDBContext : DbContext
    {
        public SchoolDBContext(DbContextOptions<SchoolDBContext> options) : base (options)
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Tutor> Tutors { get; set; }
        public DbSet<Hostel> Hostels { get; set; }        
    }
}
