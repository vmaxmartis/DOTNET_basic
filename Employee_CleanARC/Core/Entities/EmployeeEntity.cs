

namespace a.Core.Entities
{
    public class Employee : baseEntity
    {
        public string? FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? Lab { get; set; }
    }
}
