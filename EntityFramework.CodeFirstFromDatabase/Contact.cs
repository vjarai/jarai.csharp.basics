using System;

namespace Jarai.CSharp.EntityFramework.CodeFirstFromDatabase
{
    public class Contact
    {
        public DateTime Created { get; set; } = DateTime.Now;
        public int Id { get; set; }

        public DateTime? Modified { get; set; }

        public string Name { get; set; }
    }
}
