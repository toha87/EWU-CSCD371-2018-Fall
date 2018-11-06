using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityCourseWork
{
    public static class IEventExtended
    {
        public static string MyExtendedTimeNow(this IEvent time)
        {
            return "Time Now: " + time.TimeNow().ToString();
        }
    }
}
