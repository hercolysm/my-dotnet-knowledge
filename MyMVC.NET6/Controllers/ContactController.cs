using Microsoft.AspNetCore.Mvc;
using MyMVC.NET6.Context;
using MyMVC.NET6.Models;

namespace MyMVC.NET6.Controllers
{
    public class ContactController : Controller
    {
        private readonly AgendaContext _context;

        public ContactController(AgendaContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var contacts = _context.Contacts.ToList();
            return View(contacts);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Contact contact)
        {
            if (ModelState.IsValid)
            {
                _context.Contacts.Add(contact);
                _context.SaveChanges();
            }

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var contact = _context.Contacts.Find(id);

            if (contact == null) {
                return NotFound();
            }

            return View(contact);
        }

        [HttpPost]
        public IActionResult Edit(Contact contact)
        {
            if (ModelState.IsValid)
            {
                _context.Contacts.Update(contact);
                _context.SaveChanges();
            }

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var contact = _context.Contacts.Find(id);

            if (contact == null) {
                return NotFound();
            }

            return View(contact);
        }

        [HttpPost]
        public IActionResult Delete(Contact request)
        {
            var contact = _context.Contacts.Find(request.Id);

            if (contact == null) {
                return NotFound();
            }

            _context.Contacts.Remove(contact);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var contact = _context.Contacts.Find(id);

            if (contact == null) {
                return NotFound();
            }

            return View(contact);
        }
    }
}