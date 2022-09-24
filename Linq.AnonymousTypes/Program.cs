using System;
using System.Linq;
using Jarai.CSharp.Linq.Query;

namespace Jarai.CSharp.Linq.AnonymousTypes
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var adressBook = new Adressbook();

            var contactsFromBerlin =
                from contact in adressBook.Contacts
                where contact.Ort == "Berlin"
                // Passende (anonyme/namenlose) Klasse (mit den Properties Nachname und City) wird automatisch generiert
                select new{ Nachname = contact.Name, City = $"DE {contact.Postleitzahl} {contact.Ort}" };

            foreach (var adress in contactsFromBerlin)
            {
                Console.WriteLine($"{adress.Nachname} {adress.City}");
            }
        }
    }
}
