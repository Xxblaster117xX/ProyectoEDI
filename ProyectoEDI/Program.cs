using Blazored.Toast.Services;
using Blazored.Toast.Configuration;
using Blazored.Toast;
using BusinessLogic.Definition;
using ProyectoEDI.Components;

var builder = WebApplication.CreateBuilder(args);





// Otros servicios
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddScoped<MessageManager>();
builder.Services.AddBlazorBootstrap();
builder.Services.AddScoped<DataElementManager>();
var app = builder.Build();

// Configurar la aplicación
app.UseHttpsRedirection();
app.UseStaticFiles();


app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
