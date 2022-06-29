namespace API_donas.Models
{

    public interface IIntroduce
    {
        object? Introduce();
    }
    public class Contact : IIntroduce
    {

        public Guid Id { get; set; } // >> uuid
        public string? Name { get; set; }
        public string? Email { get; set; }
        public long Phone { get; set; }
        public object Introduce()
        {
            return ("here interface");
        }
        public string? Adress { get; set; } // dapper >> database first
    }
}
