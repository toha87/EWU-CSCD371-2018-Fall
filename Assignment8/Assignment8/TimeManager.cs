
using System;

namespace Assignment8UnitTest
{
    public class TimeManager
    {
        public string EventName { get; set; }
        public string StopTime { get; set; }

        public DateTime LabelTimeCurrent()
        {
            return DateTime.Now;
        }
    }
}