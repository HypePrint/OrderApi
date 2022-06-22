namespace HypePrint.OrderApi.WebApi
{
    public static class ConfigureServices
    {
        public static void AddWebApiServices(this IServiceCollection services)
        {
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
        }
    }
}
