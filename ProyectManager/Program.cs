using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using ProyectManager;
using ProyectManager.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:44353/api/") });
 
builder.Services.AddScoped<IProyectoService, ProyectoService>();

builder.Services.AddMudServices(); //Importaci�n de los servicios
await builder.Build().RunAsync();
