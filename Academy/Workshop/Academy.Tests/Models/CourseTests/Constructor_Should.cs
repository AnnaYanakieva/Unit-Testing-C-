﻿using Academy.Models;
using Academy.Models.Contracts;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Tests.Models.CourseTests
{
    [TestFixture]
    public class Constructor_Should
    {
        [Test]
        public void SetProperName_WhenObjectIsConstructed()
        {
            //Arrange & Act
            var course = new Course("Valid name", 5, new DateTime(2017, 02, 10), new DateTime(2017, 03, 10));

            //Assert
            Assert.AreEqual("Valid name", course.Name);
        }

        [Test]
        public void SetProperLecturesPerWeek_WhenObjectIsConstructed()
        {
            //Arrange & Act
            var course = new Course("Valid name", 5, new DateTime(2017, 02, 10), new DateTime(2017, 03, 10));

            //Assert
            Assert.AreEqual(5, course.LecturesPerWeek);
        }

        [Test]
        public void SetProperStaringDate_WhenObjectIsConstructed()
        {
            //Arrange & Act
            var course = new Course("Valid name", 5, new DateTime(2017, 02, 10), new DateTime(2017, 03, 10));

            //Assert
            Assert.AreEqual(new DateTime(2017, 02, 10), course.StartingDate);
        }

        [Test]
        public void InitilizeLecturesCollection_WhenObjectIsConstructed()
        {
            //Arrange & Act
            var course = new Course("Valid name", 5, new DateTime(2017, 02, 10), new DateTime(2017, 03, 10));

            //Assert - Check if collection is initiated

           // Assert.IsInstanceOf(typeof(List<ILecture>), course.Lectures);
           // Assert.AreEqual(0, course.Lectures.Count);
            Assert.IsNotNull(course.Lectures);

        }
    }
}
