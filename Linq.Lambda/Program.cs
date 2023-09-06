using System.Linq;
using Jarai.CSharp.Linq.Query;

namespace Jarai.CSharp.Linq.Lambda
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var adressBook = new Adressbook();

            // LINQ mit expliciten Methoden
            var contacts2 = adressBook.Contacts
                .Where(NameFilter)
                .Select(OrtSelector)
                .ToArray();


            // LINQ mit anonymen Methoden (Lamda Expressions)
            var contacts1 = adressBook.Contacts
                .Where(contact => contact.Name.Contains("Müller"))
                .Select(contact => contact.Ort)
                .ToArray();
            
        }

        private static string OrtSelector(Contact contact)
        {
            return contact.Ort;
        }

        private static bool NameFilter(Contact contact)
        {
            return contact.Name.Contains("Müller");
        }
    }
}
