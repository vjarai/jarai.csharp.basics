using System.Data.Entity;

namespace Jarai.CSharp.EntityFramework.CodeFirst
{
    internal class DatabaseContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }
    }
}
