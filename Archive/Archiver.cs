using System;
using System.Threading.Tasks;

namespace Archive
{
    class Archiver : IDisposable
    {
        public async Task<string> Archive(string name)
        {
            Console.WriteLine($"  Archiving {name}");

            var contents = await Download(name);
            Console.WriteLine($"    Downloaded {name}");

            var path = await Save(name, contents);
            Console.WriteLine($"    Saved {name}");

            return path;
        }

        public void Dispose()
        {

        }

        private async Task<string> Download(string name)
        {
            await Task.Delay(1000);
            return DateTime.Now.ToString();
        }

        private async Task<string> Save(string name, string contents)
        {
            await Task.Delay(1000);
            return DateTime.Now.ToString();
        }
    }
}
