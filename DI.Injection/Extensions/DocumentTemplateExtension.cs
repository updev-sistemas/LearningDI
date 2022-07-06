using DI.Injection.Contracts;
using DI.Injection.Models;
using Microsoft.Extensions.DependencyInjection;

namespace DI.Injection.Extensions
{
    public static class DocumentTemplateExtension
    {
        public static IServiceCollection AddDocument(this IServiceCollection services)
            => services.AddTransient<Document>();
    }
}