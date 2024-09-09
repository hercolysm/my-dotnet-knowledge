using Microsoft.AspNetCore.Mvc;
using MyLibraryClass.NET6.EntityFramework.Context;
using MyLibraryClass.NET6.Entities;

namespace MyWebAPI.NET6.Controllers
{
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly AgendaContext _context;

        public ContactController(AgendaContext context)
        {
            _context = context;
        }

        [HttpGet("contacts")]
        public IActionResult List(string? nome)
        {
            IQueryable<Contact> contacts; // Explicitly define the type

            if (string.IsNullOrEmpty(nome))
            {
                contacts = _context.Contacts;
            }
            else
            {
                contacts = _context.Contacts.Where(x => x.Nome.Contains(nome));
            }

            return Ok(contacts);
        }

        [HttpGet("contact/{id}")]
        public IActionResult View(int id)
        {
            var contact = _context.Contacts.Find(id);

            if (contact == null)
                return NotFound();

            return Ok(contact);
        }

        [HttpPost("contact")]
        public IActionResult Create(Contact contact)
        {
            _context.Add(contact);
            _context.SaveChanges();
            return CreatedAtAction(nameof(View), new { id = contact.Id }, contact);
        }

        [HttpPut("contact/{id}")]
        public IActionResult Edit(int id, Contact contact)
        {
            var existentContact = _context.Contacts.Find(id);

            if (existentContact == null)
                return NotFound();

            existentContact.Nome = contact.Nome;
            existentContact.Email = contact.Email;
            existentContact.Status = contact.Status;

            _context.Contacts.Update(existentContact);
            _context.SaveChanges();
            return Ok(existentContact);
        }

        [HttpDelete("contact/{id}")]
        public IActionResult Delete(int id)
        {
            var contact = _context.Contacts.Find(id);

            if (contact == null)
                return NotFound();

            _context.Contacts.Remove(contact);
            _context.SaveChanges();

            return NoContent();
        }

        [HttpGet("contact/list")]
        public IEnumerable<Contact> List()
        {
            return Enumerable.Range(0, 5).Select(index => new Contact
            {
                Id = index,
                Nome = $"Name {index}",
                Status = (index % 2 == 0 ? true : false)
            })
            .ToArray();
        }
    }
}