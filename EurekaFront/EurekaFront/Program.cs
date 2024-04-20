//using System;
//using System.Net.Http;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
//using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.DependencyInjection;
//using EurekaFront;
//using Microsoft.AspNetCore.Components.Web;

//var builder = WebAssemblyHostBuilder.CreateDefault(args);
//builder.RootComponents.Add<App>("#app");
//builder.RootComponents.Add<HeadOutlet>("head::after");

//// Configuración de las opciones desde appsettings.json
//builder.Configuration.AddJsonFile("wwwroot/appsettings.json");

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(uriString: builder.Configuration["BaseUrl"]) });

//await builder.Build().RunAsync();

// Program.cs en el lado del cliente
using EurekaFront;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Radzen;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");

builder.Services.AddScoped<DialogService>();
builder.Services.AddScoped<NotificationService>();

var appSettings = new MyAppSettings();
builder.Configuration.Bind("MyAppSettings", appSettings);

builder.Services.AddScoped(sp =>
{
    return new HttpClient
    {
        BaseAddress = new Uri(appSettings.BaseUrl)
    };
});


await builder.Build().RunAsync();

