using System;
using System.Linq;

namespace Jarai.EntityFramework.CodeFirst
{
    internal class Program
    {
        private static void LogSqlCommand(string msg)
        {
            Console.WriteLine(msg);
        }

        private static void Main(string[] args)
        {
            // Start DB Transaction
            using (var db = new DatabaseContext())
            {
                // Show Database Connection
                Console.WriteLine(db.Database.Connection.ConnectionString);

                // Activate Logging
                db.Database.Log = LogSqlCommand;

                // Create record
                var newContact = new Contact { Name = "Meier" };
                db.Contacts.Add(newContact);

                // Read record
                var firstContact = db.Contacts.First();

                // Delete record
                db.Contacts.Remove(firstContact);

                // Update record
                newContact.Modified = DateTime.Now;

                // Commit Transaction
                int changedRecords = db.SaveChanges();

                Console.WriteLine($"{changedRecords} records changed.");
            } // Rollback, if db.SaveChanges not called
        }
    }
}
