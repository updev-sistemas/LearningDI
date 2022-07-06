using DI.Injection.Commons;
using DI.Injection.Extensions;
using DI.Injection.Models;
using Microsoft.Extensions.DependencyInjection;

var servicesCollection = new ServiceCollection();

var services = servicesCollection
        .AddDocument()
        .AddSaveInDisk()
        .AddPrint()
        .BuildServiceProvider();

var doc = (Document) DICommon.CreateInstance(typeof(Document), services);

doc.Save(@"C:\Documents\arquivo.txt");
doc.Print();

_ = doc;
_ = services;
_ = servicesCollection;

