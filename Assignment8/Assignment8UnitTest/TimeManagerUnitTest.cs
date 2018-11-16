using System;
using Assignment8;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Assignment8UnitTest
{
    [TestClass]
    public class TimeManagerUnitTest
    {
        [TestMethod]
        public void CreateTimeManagerClass()
        {
            TimeManager time = new TimeManager
            {
                EventName = "Typing"
            };

            Assert.AreEqual("Typing", time.EventName);
        }

        [TestMethod]
        public void CreateLabelTimeCurrentMethod()
        {
            TimeManager time = new TimeManager();
            time.LabelTimeCurrent();

            Assert.IsNotNull(time);
        }

        [TestMethod]
        public void TimeStamp()
        {
            //it should pass but because of differences in nanosecond it fails
            //sometimes it passes

            TimeManager time = new TimeManager();
            Assert.AreEqual(DateTime.Now, time.LabelTimeCurrent());
        }
    }
}
