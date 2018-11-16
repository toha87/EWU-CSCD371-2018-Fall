using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    public class TimeNow : IDateTime
    {
        public string DateTime()
        {
            return System.DateTime.Now.ToString("HH:mm:ss");
        }

    }
}
