using NUnit.Framework;
using IntergalacticTravel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntergalacticTravel.Tests.ResourcesFactory
{
    [TestFixture]
    public class GetResources_Should
    {
        [TestCase("create resources gold(20) silver(30) bronze(40)")]
        [TestCase("create resources gold(20) bronze(40) silver(30)")]
        [TestCase("create resources silver(30) bronze(40) gold(20)")]
        public void ReturnANewlyCreastedResources_WhenInputStringIsInTheCorrectFormat(string command)
        {
            var resourcesFactory = new IntergalacticTravel.ResourcesFactory();

            var expectedGold = 20;
            var expectedSilver = 30;
            var expectedBronze = 40;

            var result = resourcesFactory.GetResources(command);

            Assert.AreEqual(expectedGold, result.GoldCoins);
            Assert.AreEqual(expectedSilver, result.SilverCoins);
            Assert.AreEqual(expectedBronze, result.BronzeCoins);
        }

        [TestCase("create resources x y z")]
        [TestCase("tansta resources a b")]
        [TestCase("absolutelyRandomStringThatMustNotBeAValidCommand ")]
        public void ThrowInvalidOperationExceptionContainingCommand_WhenStringIsInvalidCommand(string command)
        {
            var resourcesFactory = new IntergalacticTravel.ResourcesFactory();

            Assert.Throws<InvalidOperationException>(() => resourcesFactory.GetResources(command)).Message.Contains("command");
        }

        [TestCase("create resources silver(10) gold(97853252356623523532) bronze(20)")]
        [TestCase("create resources silver(555555555555555555555555555555555) gold(97853252356623523532999999999) bronze(20)")]
        [TestCase("create resources silver(10) gold(20) bronze(4444444444444444444444444444444444444)")]
        public void ThrowOverflowException_WhenStringIsInCorrectFormatButAnyValuesAreLargerThanuintMaxValue(string command)
        {
            var resourcesFactory = new IntergalacticTravel.ResourcesFactory();

            Assert.Throws<OverflowException>(() => resourcesFactory.GetResources(command));
        }
    }
}
