using System;
using System.Linq;

namespace Jarai.CSharp.Linq.Query
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var adressBook = new Adressbook();

            var contactsFromBerlin =
                from contact in adressBook.Contacts
                where contact.Ort == "Berlin"
                orderby contact.Name
                select contact;

            foreach (var item in contactsFromBerlin)
            {
                Console.WriteLine(item);
            }

            var fritz = adressBook.Contacts
                .Where(contact => contact.Name.Contains("Jarai"))
                .OrderBy(contact => contact.Name)
                .FirstOrDefault();

            Console.WriteLine(fritz);
        }
    }
}
