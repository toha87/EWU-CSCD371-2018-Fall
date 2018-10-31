using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using UniversityCourseWork;

namespace UniversityCourseWorkUnitTest
{
    [TestClass]
    public class InterfaceTestUnit
    {
        [Ignore] 
        [TestMethod]
        public void ReadLineOutputsText()
        {
            //Arrange
            RealConsole console = new RealConsole();

            //Act
            string str = console.ReadLine();

            //Assert
            Assert.AreEqual("Foo", str);
        }

        [TestMethod]
        public void WriteLineOutputsText()
        {
            //Arrange
            RealConsole console = new RealConsole();


            MainProgramClass.MyConsole = console;

            List<Schedule> list = new List<Schedule> { new Schedule(125, 320, "Algorithms", "10.17.2018") };


            //Assert
            Assert.AreEqual("Foo", console.LastWrittenLine);
        }

    }
}
