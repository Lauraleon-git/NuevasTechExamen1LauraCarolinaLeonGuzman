using Examen.API.Contratos.Repositorio;
using Examen.API.Implementacion.Repositorio;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var host = new HostBuilder()
    .ConfigureFunctionsWebApplication()
    .ConfigureServices(services =>
    {
        services.AddApplicationInsightsTelemetryWorkerService();
        services.ConfigureFunctionsApplicationInsights();
        services.AddTransient<IProveedorRepositorio, ProveedorRepositorio>();
        
    })
    .Build();

host.Run();
