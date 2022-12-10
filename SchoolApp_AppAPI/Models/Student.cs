namespace SchoolApp_AppAPI.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public string? Sex { get; set; }
        public string? Imgurl { get; set; }
        public DateTime Dob { get; set; }
        public DateTime Regdate { get; set; }
        public IList<Course>? Courses { get;set; }
        public Hostel? Hostel { get; set; }
    }
}
