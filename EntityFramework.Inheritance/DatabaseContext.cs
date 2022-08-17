using System.Data.Entity;
using Jarai.EntityFramework.Inheritance.Entities;

namespace Jarai.EntityFramework.Inheritance
{
    internal class DatabaseContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }
    }
}
