using System.Data.Entity;
using Jarai.CSharp.EntityFramework.Inheritance.Entities;

namespace Jarai.CSharp.EntityFramework.Inheritance
{
    internal class DatabaseContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }
    }
}
