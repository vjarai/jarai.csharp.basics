namespace Jarai.CSharp.Linq.Query
{
    // Website 101 Linq

    internal class Program
    {
        /// <summary>
        ///     LINQ => Language Integrated Native Query
        ///     Abfragen auf ein Objektmodell im Speicher
        /// </summary>
        private static void Main(string[] args)
        {
            var adressBook = new Adressbook();

            // LINQ Query Syntax
            var contactsFromBerlinQuery = // Ergebnisvariable
                from contact in adressBook.Contacts // entspricht Schleife
                where contact.Ort.ToUpper() == "BERLIN" // Filter
                orderby contact.Name // Sort
                select contact; // Ins Ergebnis übernehmen

            // Oder Alternativ LINQ Methoden Syntax
            var contactsFromMunichQuery = adressBook.Contacts
                .Where(contact => contact.Ort.ToUpper() == "MÜNCHEN")
                .OrderBy(contact => contact.Name);

            foreach (var item in contactsFromBerlinQuery)
            {
                Console.WriteLine(item);
            }
        }
    }
}
