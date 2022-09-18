using System.Linq;
using Jarai.CSharp.Linq.Query;

namespace Jarai.CSharp.Linq.Lambda
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var adressBook = new Adressbook();

            var sortedByOrtContacts = adressBook.Contacts.OrderBy(c => c.Ort).ToArray();
            var sortedByNameContacts = adressBook.Contacts.OrderBy(c => c.Name).ToArray();

            var filteredContacts = adressBook.Contacts.Where(c => c.Ort == "Berlin").ToArray();
        }
    }
}
