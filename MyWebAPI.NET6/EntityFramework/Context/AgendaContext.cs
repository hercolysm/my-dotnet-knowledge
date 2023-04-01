using MyLibraryClass.NET6.Entities;
using Microsoft.EntityFrameworkCore;

namespace MyLibraryClass.NET6.EntityFramework.Context
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        {

        }

        public DbSet<Contact> Contacts { get; set; }
    }
}