using System;
using System.IO;

namespace Assignment7UnitTest
{
    public class ResourceManagement : IDisposable
    {
        public static int COUNT = 0;

        private StreamReader FileReader { get; }
        public ResourceManagement(string fileName)
        {
            
            FileReader = new StreamReader(fileName);
            COUNT++;
        }

        ~ResourceManagement()
        {
            Dispose();
            COUNT--;
            
        }

        public void Dispose()
        {
            FileReader?.Dispose();
        }
    }
}