using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Assignment9.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InventorNamesTestWithSpecifiedCountry_Count()
        {
          int count =  PatentDataAnalyzer.InventorNames("USA").Count;

          Assert.AreEqual(6, count);
        }

        [TestMethod]
        public void InventorNamesTestWithSpecifiedCountry_Success()
        {
            List<string> expected = new List<string>();
            expected.Add("Benjamin Franklin");
            expected.Add("Orville Wright");
            expected.Add("Wilbur Wright");
            expected.Add("Samuel Morse");
            expected.Add("John Michaelis");
            expected.Add("Mary Phelps Jacob");

            List<string> list = PatentDataAnalyzer.InventorNames("USA");

            Assert.IsTrue(list != null && list.SequenceEqual(expected));
        }


        [TestMethod]
        public void OnlyLastNamesOfEachOfInventorSortedInReverseOrderByInventorId()
        {
            List<string> listWithLastNames = PatentDataAnalyzer.InventoryLastNames();

            var firstElement = listWithLastNames.First();

            Assert.AreEqual("Jacob", firstElement);
        }

        [TestMethod]
        public void SingleCommaSeparatedListOfStateAndTheCountryStringsForEachInventor()
        {
            string expected = "PA-USA, NC-USA, NY-USA, Northumberland-UK, IL-USA";

            string list = PatentDataAnalyzer.LocationsWithInventors();

            Assert.AreEqual(expected, list);
        }

        [TestMethod]
        public void ReturnsAnIEnumerableTOfOriginalItemsInRandomOrder()
        {
            IEnumerable<Inventor> list = PatentData.Inventors.ToList();


            for (int i = 0; i < 3; i++)
            {
                IEnumerable<Inventor> listToTest = PatentData.Inventors.Randomize().ToList();

                Assert.AreNotEqual(list, listToTest);

                list = listToTest;
            }

        }

    }
}
