using System;

namespace Jarai.Dataset.Obsolete
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var tableAdapter = new ContactsTableAdapter();
            var dataset = new DataSet1();
            tableAdapter.Fill(dataset.Contacts);

            foreach (var contact in dataset.Contacts)
            {
                Console.WriteLine($"{contact.Id} {contact.Name} {contact.Created}");
            }
        }
    }
}
