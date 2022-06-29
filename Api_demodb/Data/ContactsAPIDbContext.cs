using API_donas.Models;
using Microsoft.EntityFrameworkCore;

namespace API_donas.Data
{
    public class ContactsAPIDbContext : DbContext
    {
        //contructor
        public ContactsAPIDbContext(DbContextOptions options) : base(options)
        {

        }
        //propety
        public DbSet<Contact> Contacts { get; set; }
    }
}
