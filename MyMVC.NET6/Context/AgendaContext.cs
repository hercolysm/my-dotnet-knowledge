using Microsoft.EntityFrameworkCore;
using MyMVC.NET6.Models;

namespace MyMVC.NET6.Context
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        {

        }

        public DbSet<Contact> Contacts { get; set; }
    }
}