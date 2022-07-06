using DI.Injection.Contracts;
using Microsoft.Extensions.DependencyInjection;

namespace DI.Injection.Extensions
{
    public static class PrintServiceExtensions
    {
        public static IServiceCollection AddPrint(this IServiceCollection services)
            => services.AddScoped<IPrint, Print>();
    }
}