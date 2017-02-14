using IntergalacticTravel.Contracts;
using Moq;
using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntergalacticTravel.Tests.TeleportStation
{
    [TestFixture]
    public class Constructor_Should
    {
        [Test]
        public void SetUpAllProvidedFields_WhenNewTeleportStationIsCreatedWithValidParameters()
        {
            var ownerMock = new Mock<IBusinessOwner>();
            var galacticMapMock = new Mock<IEnumerable<IPath>>();
            var locationMock = new Mock<ILocation>();

            var teleportStation = 
                new Mocks.TeleportStationMocks(ownerMock.Object, galacticMapMock.Object, locationMock.Object);
            //  new IntergalacticTravel.TeleportStation(ownerMock.Object, galacticMapMock.Object, locationMock.Object);

            Assert.AreEqual(ownerMock.Object, teleportStation.Owner);
            Assert.AreEqual(galacticMapMock.Object, teleportStation.GalacticMap);
            Assert.AreEqual(locationMock.Object, teleportStation.Location);
        }
    }
}
