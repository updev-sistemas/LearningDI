using DI.Injection.Contracts;

namespace DI.Injection.Models
{
    public class Document
    {
        private readonly IPrint? _print;
        private readonly IDiskManager? _disk;

        public Document(IPrint print, IDiskManager disk)
        {
            _print = print;
            _disk = disk;
        }

        public void Print() => _print?.Impress();
        public void Save(string path) => _disk?.Save(path);
    }
}
