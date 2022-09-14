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
            new Contact { Name = "Susi Müller", Postleitzahl = 12345, Ort = "Berlin" },
            new Contact { Name = "Franz Meier", Postleitzahl = 13456, Ort = "Berlin" },
            new Contact { Name = "Bart Simpson", Postleitzahl = 81234, Ort = "München" },
            new Contact { Name = "Viktor Jarai", Postleitzahl = 65779, Ort = "Kelkheim" }
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
