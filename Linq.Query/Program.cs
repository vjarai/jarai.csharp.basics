using System;
using System.Collections.Generic;
using System.Linq;

namespace Jarai.CSharp.Linq.Query
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var adressBook = new[]
            {
                new Contact { Name = "Fritz Müller", Postleitzahl = 12345, Ort = "Berlin" },
                new Contact { Name = "Susi Müller", Postleitzahl = 12345, Ort = "Berlin" },
                new Contact { Name = "Franz Meier", Postleitzahl = 13456, Ort = "Berlin" },
                new Contact { Name = "Bart Simpson", Postleitzahl = 81234, Ort = "München" },
                new Contact { Name = "Viktor Jarai", Postleitzahl = 65779, Ort = "Kelkheim" }
            };

            // LINQ Query Syntax
            var contactsFromBerlin =
                    from contact in adressBook
                    where contact.Ort == "Berlin"
                    orderby contact.Name
                    select contact;

            foreach (var item in contactsFromBerlin)
            {
                Console.WriteLine(item);
            }

            // LINQ Methoden Syntax (mit => Lambda Expressions)
            var fritz = adressBook
                .Where(contact => contact.Name.Contains("Jarai"))
                .OrderBy(contact => contact.Name)
                .FirstOrDefault();

            Console.WriteLine(fritz);
        }
    }
}
