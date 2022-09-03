using Jarai.CSharp.Linq.Query;

namespace Jarai.CSharp.Linq.Lambda
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var adressBook = new Adressbook();

            var sortedByOrtContacts = adressBook.GetSortedContacts(c => c.Ort);
            var sortedByNameContacts = adressBook.GetSortedContacts(c => c.Name);

            var filteredContacts = adressBook.GetFilteredContacts(c => c.Ort == "Berlin");
        }
    }
}
