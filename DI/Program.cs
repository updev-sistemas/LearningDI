using DI.Injection.Contracts;
using DI.Injection.Extensions;
using Microsoft.Extensions.DependencyInjection;

var servicesCollection = new ServiceCollection();
servicesCollection.AddSaveInDisk();
servicesCollection.AddPrint();

servicesCollection.AddTransient<Document>();

var services = servicesCollection.BuildServiceProvider();

var doc = (Document) DICommon.CreateInstance(typeof(Document), services);

doc.Save(@"C:\Documents\arquivo.txt");
doc.Print();

_ = doc;
_ = services;
_ = servicesCollection;

class Document
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