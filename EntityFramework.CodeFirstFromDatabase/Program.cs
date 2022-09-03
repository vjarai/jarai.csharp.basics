using System.Linq;

namespace Jarai.CSharp.EntityFramework.CodeFirstFromDatabase
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using (var db = new DatabaseContext())
            {
                var contacts = db.Contacts.Add(new Contact(){Name = "Test"});
                db.SaveChanges();
            }
        }
    }
}
