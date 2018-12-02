using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Archive
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new string[] { "Foo", "Bar", "Baz" };

            Task.Run(() => ArchiveBooks(books)).Wait();
        }

        static async Task ArchiveBooks(IEnumerable<string> books)
        {
            Console.WriteLine("Starting archive...");
            using (var archiver = new ExplicitArchiver())
            {
                foreach (var book in books)
                {
                    await archiver.Archive(book);
                }
            }
            Console.WriteLine("Done!");
        }
    }
}
