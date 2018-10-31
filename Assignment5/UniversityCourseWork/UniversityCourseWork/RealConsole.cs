using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityCourseWork
{
    public class RealConsole : IConsole
    {
        public string LastWrittenLine { get; set; }

        public void WriteLine(string line)
        {
            if (line == null) throw new ArgumentNullException(nameof(line));
            LastWrittenLine = line;
            Console.WriteLine(line);

        }

        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
