using DI.Injection.Contracts;

namespace DI.Injection
{
    public class Disk : IDiskManager
    {
        public void Save(string path)
        {
            Console.WriteLine($"File save in >> {path}");
        }
    }
}