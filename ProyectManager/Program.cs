using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using ProyectManager;
using ProyectManager.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7294/api/") });
 
builder.Services.AddScoped<IProyectoService, ProyectoService>();
builder.Services.AddScoped<IColaboradorService, ColaboradorService>();

builder.Services.AddMudServices(); //Importación de los servicios
await builder.Build().RunAsync();
