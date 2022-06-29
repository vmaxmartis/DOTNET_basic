namespace API_donas.Models
{
    public class AddContactRequest
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public long Phone { get; set; }
        /*public object Introduce()
        {
            return ("Giới thiệu bản thân");
        }*/
        public string Adress { get; set; }
    }
}
