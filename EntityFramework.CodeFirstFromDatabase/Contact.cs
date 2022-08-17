using System;

namespace Jarai.EntityFramework.CodeFirstFromDatabase
{
    public class Contact
    {
        public DateTime Created { get; set; }
        public int Id { get; set; }

        public DateTime? Modified { get; set; }

        public string Name { get; set; }
    }
}
