using Academy.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Tests.Models.CourseTests
{
    [TestFixture]
    public class SetLecturesPerWeek_Should
    {
        [TestCase(0)]
        [TestCase(8)]
        public void ThrowsArgumentException_WhenInvalidValueIsPassed(int lecturesPerWeek)
        {
            //Arrange
            var course = new Course("Valid name", 5, new DateTime(2017, 02, 10), new DateTime(2017, 03, 10));

            //Act & Assert
            Assert.Throws<ArgumentException>(() => course.LecturesPerWeek = lecturesPerWeek);
        }
    }
}
