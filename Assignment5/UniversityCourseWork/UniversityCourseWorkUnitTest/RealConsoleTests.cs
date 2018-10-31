using IntelliTect.TestTools.Console;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using UniversityCourseWork;

namespace UniversityCourseWorkUnitTest
{
    [TestClass]
    public class RealConsoleTests
    {
        [TestMethod]
        public void WriteLineOutputsFoo()
        {
            ConsoleAssert.Expect("Hello World!", WriteToConsole);
            
        }

        private void WriteToConsole()
        {
            RealConsole console = new RealConsole();

            console.WriteLine("Hello World!");
        }

        [TestMethod]
        public void ReadLineOutputsText()
        {
            RealConsole console = new RealConsole();

            console.WriteLine("Foo");

            Assert.AreEqual("Foo", console.LastWrittenLine);
        }
    }
}
