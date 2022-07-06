using DI.Injection;
using Microsoft.Extensions.DependencyInjection;

var servicesCollection = new ServiceCollection();
servicesCollection.AddPrint();

servicesCollection.AddTransient<Document>();

var services = servicesCollection.BuildServiceProvider();

var doc = (Document) CommonExtensions.CreateInstance(typeof(Document), services);

doc.Print();

_ = doc;
_ = services;
_ = servicesCollection;

class Document
{
    private readonly IPrint? print;
    
    public Document(IPrint print) => this.print = print;

    public void Print() => this.print?.Impress();
}