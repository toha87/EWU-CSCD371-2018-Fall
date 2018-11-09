using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Assignment7UnitTest
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void CreateClassResourceManagement()
        {
            ResourceManagement resource = new ResourceManagement("test.txt");
        }

        [TestMethod]
        public void UsingExample()
        {

            {
                ResourceManagement myResourceManagement = null;
                try
                {

                    myResourceManagement = new ResourceManagement(@"C:\course\Testing\myFile.txt");

                }
                finally
                {
                    myResourceManagement?.Dispose();
                }

            }
        }

        [TestMethod]

        public void TestClassForNULL()
        {

            NonNullable<int> myNonNullable = new NonNullable<int>();

            Assert.IsNotNull(myNonNullable.Value);

        }

    }
}
