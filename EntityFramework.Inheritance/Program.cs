using System;
using System.Linq;
using Jarai.EntityFramework.Inheritance.Entities;

namespace Jarai.EntityFramework.Inheritance
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Start DB Transaction
            using (var db = new DatabaseContext())
            {
                // Create BusinessContact
                var businessContact = new BusinessContact { Name = "Max Mustermann", CompanyName = "Mustermann AG" };
                db.Contacts.Add(businessContact);

                // Create PrivateContact
                var privateContact = new PrivateContact { Name = "Donald Duck", PrivateAdress = "Entenhausen" };
                db.Contacts.Add(privateContact);

                // Commit Transaction
                int changedRecords = db.SaveChanges();
                Console.WriteLine($"{changedRecords} records changed.");

                var donaldDuck = db.Contacts.OfType<PrivateContact>().Where(c => c.Name.Contains("Duck")).FirstOrDefault();
                var maxMustermann = db.Contacts.Where(c => c.Name.Contains("Max")).FirstOrDefault();
            }
        }
    }
}
