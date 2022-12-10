namespace SchoolApp_AppAPI.Models
{
    public class Hostel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Address   { get; set; }
        public string? Patron { get; set; }
        public IList<Student>? Students { get; set; }
    }
}
