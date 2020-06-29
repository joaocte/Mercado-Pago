using Microsoft.Extensions.DependencyInjection;

namespace MercadoPago.Core.Middleware
{
    public static class IServiceCollectionExtensions
    {
        private static bool executed;

        public static IServiceCollection AddMPCache(this IServiceCollection services)
        {
            if (!executed)
            {
                services.AddMemoryCache();

                executed = true;
            }

            return services;
        }
    }
}