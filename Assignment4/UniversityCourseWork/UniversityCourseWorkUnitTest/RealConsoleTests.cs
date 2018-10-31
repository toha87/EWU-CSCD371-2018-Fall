using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UniversityCourseWork;

namespace UniversityCourseWorkUnitTest
{
    [TestClass]
    public class RealConsoleTests
    {
        [TestInitialize]
        public void TestSetup()
        {
            RealConsole console = new RealConsole();
        }

        [TestMethod]
        public void WriteLineOutputsFoo()
        {
            ConsoleAssert.Expect("Foo", WriteFoo);
            
        }

        private void WriteFoo()
        {
            RealConsole console = new RealConsole();

            console.WriteLine("Foo");
        }
    }
}
