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
        public IActionResult List(string nome)
        {
            var contacts = _context.Contacts.Where(x => x.Nome.Contains(nome));
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
            //return Ok(contact);
            return CreatedAtAction(nameof(View), new { id = contact.Id }, contact);
        }

        [HttpPut("contact/{id}")]
        public IActionResult Edit(int id, Contact contact)
        {
            var contact2 = _context.Contacts.Find(id);

            if (contact2 == null)
                return NotFound();

            contact2.Nome = contact.Nome;
            contact2.Status = contact.Status;

            _context.Contacts.Update(contact2);
            _context.SaveChanges();
            return Ok(contact2);
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
    }
}