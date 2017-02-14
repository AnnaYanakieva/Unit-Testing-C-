using IntergalacticTravel.Exceptions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntergalacticTravel.Tests.UnitsFactoryTests
{
    [TestFixture]
    public class GetUnit_Should
    {
        [Test]
        public void ReturnNewProcyon_WhenCorrespondingCommandIsPassed()
        {
            //Arrange
            var command = "create unit Procyon Gosho 1";
            var unitsFactory = new UnitsFactory();

            //Act
            var actualUnit = unitsFactory.GetUnit(command);

            //Assert
            Assert.IsInstanceOf<Procyon>(actualUnit);
        }

        [Test]
        public void ReturnNewLuyten_WhenCorrespondingCommandIsPassed()
        {
            //Arrange
            var command = "create unit Luyten Pesho 2";
            var unitsFactory = new UnitsFactory();

            //Act
            var actualUnit = unitsFactory.GetUnit(command);

            //Assert
            Assert.IsInstanceOf<Luyten>(actualUnit);
        }

        [Test]
        public void ReturnNewLacaille_WhenCorrespondingCommandIsPassed()
        {
            //Arrange
            var command = "create unit Lacaille Tosho 3";
            var unitsFactory = new UnitsFactory();

            //Act
            var actualUnit = unitsFactory.GetUnit(command);

            //Assert
            Assert.IsInstanceOf<Lacaille>(actualUnit);
        }

        [TestCase("create unit Banana Tosho 3")]
        [TestCase("create unit Lacaille 3")]
        public void ThrowInvalidUnitCreationCommandException_WhenCorrespondingCommandIsNotInValidFormat(string command)
        {
            //Arrange      
            var unitsFactory = new UnitsFactory();

            //Act & Assert
            Assert.Throws<InvalidUnitCreationCommandException>(() => unitsFactory.GetUnit(command));
        }
    }    
}
