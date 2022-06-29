using API_donas.Data;
using API_donas.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_donas.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ContactsController : Controller
    {   //contructor
        private readonly ContactsAPIDbContext dbContext;

        public ContactsController(ContactsAPIDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        //get

        [HttpGet]
        [Route("findAll")]
        public async Task<IActionResult> GetContacts()
        {
            return Ok(await dbContext.Contacts.ToListAsync());
        }
        //get simple

        [HttpGet]

        [Route("findOne/{id:guid}")]
        public async Task<IActionResult> GetsimpleContact([FromRoute] Guid id)
        {
            var contact = await dbContext.Contacts.FindAsync(id);
            if (contact == null)
            {
                return NotFound("Contact information for ID: " + id + "does not exist");
            }
            return Ok(contact);
        }
        //post
        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> AddContacts(AddContactRequest addContactRequest)
        {


            // khai báo biến đầu vào Post
            var contact1 = new Contact()
            {
                Id = Guid.NewGuid(),
                Adress = addContactRequest.Adress,
                Name = addContactRequest.Name,

                Email = addContactRequest.Email
            };
            //thực thi
            await dbContext.Contacts.AddAsync(contact1);
            await dbContext.SaveChangesAsync();
            return Ok("Successfully added new contact information: " + contact1.Name);

        }
        //PUT

        [HttpPut]
        [Route("update/{id:guid}")]
        public async Task<IActionResult> UpdateContacts([FromRoute] Guid id, UpdateContactRequest updateContactRequest)
        {
            var contact = await dbContext.Contacts.FindAsync(id);
            if (contact != null)
            {


                contact.Adress = updateContactRequest.Adress;
                contact.Name = updateContactRequest.Name;
                contact.Phone = updateContactRequest.Phone;
                contact.Email = updateContactRequest.Email;

                await dbContext.SaveChangesAsync();
                return Ok("Successfully updated" + contact.Name);
            }
            return NotFound("Successfully updated contact information:" + id + "does not exist >> update failed");


        }
        //Patch

        [HttpPatch]
        [Route("microUpdate/{id:guid}")]
        public async Task<IActionResult> MicroUpdateContacts([FromRoute] Guid id, MicroUpdateContactsRequest microUpdateContactsRequest)
        {
            var contact = await dbContext.Contacts.FindAsync(id);
            if (contact != null)
            {
                contact.Adress = microUpdateContactsRequest.Adress;
                contact.Name = microUpdateContactsRequest.Name;
                contact.Phone = microUpdateContactsRequest.Phone;
                contact.Email = microUpdateContactsRequest.Email;

                await dbContext.SaveChangesAsync();
                return Ok(contact);
            }
            return NotFound("Contact information for ID: " + id + "does not exist >> update failed");


        }


        [HttpDelete]
        [Route("delete/{id:guid}")]
        public async Task<IActionResult> DeleteContacts([FromRoute] Guid id, DeleteContactRequest deleteContactRequest)
        {
            var contact = await dbContext.Contacts.FindAsync(id);
            if (contact != null)
            {
                dbContext.Remove(contact);
                await dbContext.SaveChangesAsync();
                return Ok(contact);
            }
            return NotFound("Contact information for ID: " + id + "does not exist >> removal failed");


        }
        public class DeleteContactRequest { }


    }


}
