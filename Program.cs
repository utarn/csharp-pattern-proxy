using System;

namespace pattern_proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            var library = new Library();
            string[] fileNames = { "a", "b", "c" };
            foreach (var filename in fileNames)
            {
                library.AddBook(new RealBook(filename));
            }

            library.OpenBook("a");
            library.OpenBook("b");
        }
    }
}
