using DI.Injection.Contracts;
using Microsoft.Extensions.DependencyInjection;

namespace DI.Injection.Extensions
{
    public static class DiskManagerExtension
    {
        public static void AddSaveInDisk(this IServiceCollection services)
        {
            services.AddScoped<IDiskManager, Disk>();
        }
    }
}