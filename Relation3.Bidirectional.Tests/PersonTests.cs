using System;
using Xunit;

namespace Jarai.CSharp.Relation.Bidirectional.Tests
{
    public class PersonTests
    {
        [Fact]
        public void Kann_nicht_heiraten_wenn_verheiratet()
        {
            // Arrange
            var person1 = new Person("Susi", "Sorglos");
            var person2 = new Person("Fritz", "Müller");
            var person3 = new Person("Max", "Mustermann");
            person1.Heiraten(person2);

            // Act & Assert
            Assert.Throws<Exception>(() => person1.Heiraten(person3));
        }

        [Fact]
        public void Kann_sich_nicht_selbst_heiraten()
        {
            // Arrange
            var person = new Person("Fritz", "Müller");

            // Act & Assert
            Assert.Throws<Exception>(() => person.Heiraten(person));
        }

        [Fact]
        public void Kann_sich_nicht_trennen_wenn_ledig()
        {
            // Arrange
            var person = new Person("Fritz", "Müller");

            // Act & Assert
            Assert.Throws<Exception>(() => person.Trennen());
        }


        [Fact]
        public void Haben_korrekten_Partner_nach_heirat()
        {
            // Arrange
            var person1 = new Person("Susi", "Sorglos");
            var person2 = new Person("Fritz", "Müller");

            // Act
            person1.Heiraten(person2);

            // Act & Assert
            Assert.Equal(person2, person1.Partner);
            Assert.Equal(person1, person2.Partner);
        }


        [Fact]
        public void Haben_keinen_Partner_nach_trennung()
        {
            // Arrange
            var person1 = new Person("Susi", "Sorglos");
            var person2 = new Person("Fritz", "Müller");

            // Act
            person1.Heiraten(person2);
            person2.Trennen();

            // Act & Assert
            Assert.Null(person1.Partner);
            Assert.Null(person2.Partner);
        }
    }
}
