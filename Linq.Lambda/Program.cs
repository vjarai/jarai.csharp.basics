using System.Linq;
using Jarai.CSharp.Linq.Query;

namespace Jarai.CSharp.Linq.Lambda
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var adressBook = new Adressbook();

            var sortedByOrtContacts1 = adressBook.Contacts
                .Where(contact => contact.Name == "Müller")
                .Select(contact => contact.Ort)
                .ToArray();

            var sortedByOrtContacts2= adressBook.Contacts
                .Where(NameFilter)
                .Select(OrtSelector)
                .ToArray();
            
        }

        private static string OrtSelector(Contact contact)
        {
            return contact.Ort;
        }

        private static bool NameFilter(Contact contact)
        {
            return contact.Name == "Müller";
        }
    }
}
