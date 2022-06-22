using HypePrint.OrderApi.Application;
using HypePrint.OrderApi.Infrastructure;
using HypePrint.OrderApi.WebApi;

// create web application from args
var builder = WebApplication.CreateBuilder(args);

// inject services into builder
builder.Services.AddApplicationServices();
builder.Services.AddInfrastructureServices(builder.Configuration);
builder.Services.AddWebApiServices();

// create web application from services
var app = builder.Build();

// configure development middleware
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// configure generic middleware
app.MapControllers();

// run web application
app.Run();
