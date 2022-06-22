using System.Reflection;
using FluentValidation.AspNetCore;
using Microsoft.OpenApi.Models;

namespace HypePrint.OrderApi.WebApi;

public static class ConfigureServices
{
    public static void AddWebApiServices(this IServiceCollection services)
    {
        services.AddControllers().AddFluentValidation();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen(options =>
        {
            options.SwaggerDoc("v1", new OpenApiInfo
            {
                Version = "v1",
                Title = "Order API",
                Description = "Manages orders in the HypePrint package",
                TermsOfService = new Uri("https://github.com/HypePrint/OrderApi/blob/master/CODE_OF_CONDUCT.md"),
                Contact = new OpenApiContact
                {
                    Name = "NullWoof",
                    Url = new Uri("https://github.com/NullWoof")
                },
                License = new OpenApiLicense
                {
                    Name = "MIT",
                    Url = new Uri("https://github.com/HypePrint/OrderApi/blob/master/LICENSE")
                }
            });

            options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory,
                $"{Assembly.GetExecutingAssembly().GetName().Name}.xml"));
            options.EnableAnnotations();
        });
    }
}