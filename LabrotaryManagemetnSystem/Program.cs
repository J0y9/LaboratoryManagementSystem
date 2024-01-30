using LaboratoryManagementSystem.Data;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

Console.WriteLine();
var builder = Host.CreateDefaultBuilder(args);
builder.ConfigureServices((hostContext, services) =>
{
    services.AddDbContext<LmsDbContext>();
});

var host = builder.Build();
