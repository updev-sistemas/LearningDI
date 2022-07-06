using Microsoft.Extensions.DependencyInjection;

namespace DI.Injection
{
    public static class CommonExtensions
    {
        public static void AddPrint(this IServiceCollection services)   
        {
            services.AddScoped<IPrint, Print>();
        }

        public static object CreateInstance(Type type, IServiceProvider serviceProvider)
        {
            var ctor = type.GetConstructors()
                .Where(c => c.IsPublic)
                .OrderByDescending(c => c.GetParameters().Length)
                .FirstOrDefault()
                ?? throw new InvalidOperationException($"No suitable contructor found on type '{type}'");

            var injectionServices = ctor.GetParameters()
                .Select(p => serviceProvider.GetRequiredService(p.ParameterType))
                .ToArray();

            return ctor.Invoke(injectionServices);
        }
    }
}