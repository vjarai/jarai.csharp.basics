using System;

namespace Jarai.EntityFramework.CodeFirst
{
    public class Contact
    {
        public Contact()
        {
            Created = DateTime.Now;
        }

        public DateTime Created { get; set; }

        public int Id { get; set; }

        public DateTime? Modified { get; set; }

        public string Name { get; set; }
    }
}
