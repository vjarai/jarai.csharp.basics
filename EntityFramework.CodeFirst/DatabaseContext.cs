using System.Data.Entity;

namespace Jarai.EntityFramework.CodeFirst
{
    internal class DatabaseContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }
    }
}
