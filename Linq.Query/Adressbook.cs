using System;
using System.Collections.Generic;
using System.Linq;

namespace Jarai.CSharp.Linq.Query
{
    public class Adressbook
    {
        public IEnumerable<Contact> Contacts { get; } = new List<Contact>
        {
            new Contact { Name = "Fritz Müller", Postleitzahl = 12345, Ort = "Berlin" },
            new Contact { Name = "Fritz Müller", Postleitzahl = 12345, Ort = "Berlin" },
            new Contact { Name = "Fritz Müller", Postleitzahl = 12345, Ort = "Berlin" },
            new Contact { Name = "Fritz Müller", Postleitzahl = 12345, Ort = "Berlin" },
            new Contact { Name = "Fritz Müller", Postleitzahl = 12345, Ort = "Berlin" }
        };

        public IEnumerable<Contact> GetFilteredContacts(Predicate<Contact> filterPredicate)
        {
            return Contacts.Where(c => filterPredicate(c));
        }

        public IEnumerable<Contact> GetSortedContacts(Func<Contact, object> sortFieldSelector)
        {
            return Contacts.OrderBy(sortFieldSelector);
        }
    }
}
