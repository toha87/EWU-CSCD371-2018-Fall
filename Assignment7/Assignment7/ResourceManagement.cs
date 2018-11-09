using System;
using System.IO;

namespace Assignment7UnitTest
{
    public class ResourceManagement : IDisposable
    {
<<<<<<< HEAD
        private StreamReader FileReader { get; }
        public static int count = 0;

        public ResourceManagement()
        {
        }

        public ResourceManagement(string fileName)
        {
            FileReader = new StreamReader(fileName);
            count++;
=======
        public static int COUNT = 0;

        private StreamReader FileReader { get; }
        public ResourceManagement(string fileName)
        {
            
            FileReader = new StreamReader(fileName);
            COUNT++;
>>>>>>> assignment7
        }

        ~ResourceManagement()
        {
            Dispose();
<<<<<<< HEAD
=======
            COUNT--;
            
>>>>>>> assignment7
        }

        public void Dispose()
        {
            FileReader?.Dispose();
<<<<<<< HEAD
            count--;
        }

=======
        }
>>>>>>> assignment7
    }
}