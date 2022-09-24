using System;
using System.Linq;

namespace Jarai.CSharp.Linq.Query
{

    // Website 101 Linq

    internal class Program
    {
        /// <summary>
        /// LINQ => Language Integrated Native Query
        /// Abfragen auf ein Objektmodell im Speicher
        /// </summary>
        private static void Main(string[] args)
        {
            var adressBook = new Adressbook();

            // LINQ Query Syntax
            var contactsFromBerlin =                 // Ergebnisvariable
                from contact in adressBook.Contacts  // entspricht Schleife
                where contact.Ort == "Berlin"        // Filter
                orderby contact.Name                 // Sort
                select  contact;                      // Ins Ergebnis übernehmen

            // Oder Alternativ LINQ Methoden Syntax
            var contactsFromMunich = adressBook.Contacts
                .Where(contact => contact.Ort.StartsWith( "München"))
                .OrderBy(contact => contact.Name);


            foreach (var item in contactsFromBerlin)
            {
                Console.WriteLine(item);
            }

            // LINQ Methoden Syntax (mit => Lambda Expressions)
            var fritz = adressBook.Contacts
                .Where(contact => contact.Name.Contains("Jarai"))
                .OrderBy(contact => contact.Name)
                .FirstOrDefault();

            Console.WriteLine(fritz);
        }
    }
}
