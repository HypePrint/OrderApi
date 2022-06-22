using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HypePrint.OrderApi.Infrastructure;

public static class ConfigureServices
{
    public static void AddInfrastructureServices(this IServiceCollection services,
        IConfiguration configuration)
    {
    }
}