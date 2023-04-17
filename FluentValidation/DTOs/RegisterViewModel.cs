namespace FluentValidationing.DTOs
{
    public class RegisterViewModel
    {
        public string Name { get; set; }
        
        public string Familty { get; set; }
        
        public string PhoneNumber { get; set; }
        
        public int Age { get; set; }

        public DateTime BearthDay { get; set; }

        public string Email { get; set; }

        public List<CourseViewModel> course { get; set; }
    }
}
