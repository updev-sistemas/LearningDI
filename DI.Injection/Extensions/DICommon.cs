using Microsoft.Extensions.DependencyInjection;

namespace DI.Injection.Extensions
{
    public static class DICommon
    { 
        public static object CreateInstance(Type type, IServiceProvider serviceProvider)
        {
            var ctor = type.GetConstructors()
                .Where(c => c.IsPublic)
                .OrderByDescending(c => c.GetParameters().Length)
                .FirstOrDefault();

            _ = ctor ?? throw new InvalidOperationException($"No suitable contructor found on type '{type}'");

            var injectionServices = ctor.GetParameters()
                .Select(p => serviceProvider.GetRequiredService(p.ParameterType))
                .ToArray();

            return ctor.Invoke(injectionServices);
        }
    }
}