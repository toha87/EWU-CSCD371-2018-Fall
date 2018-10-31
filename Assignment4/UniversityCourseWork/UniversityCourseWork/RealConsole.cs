using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityCourseWork
{
    public class RealConsole : IConsole
    {
        public string LastWrittenLine { get; private set; }

        public void WriteLine(string line)
        {
            if (line == null) throw new ArgumentNullException(nameof(line));
            Console.WriteLine(line);

        }

        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
