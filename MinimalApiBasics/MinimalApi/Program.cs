using MinimalApi.Configurations;
using MinimalApi.Configurations.Endpoints;
using MinimalApi.IServices;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAccountServies();
builder.Services.AddBusinessServies();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.EnableAnnotations();
} );

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI( options =>
{
    options.SwaggerEndpoint("~/swagger/v1/swagger.json", "Minimal Basics");
    options.RoutePrefix = string.Empty;

} );
//app.MapGet("/", () => "Hello World!");
app.ConfigureBusinessEndpoints();
app.ConfigureAccountEndpoints();
app.Run();
