using Blazored.Toast.Services;
using Blazored.Toast.Configuration;
using Blazored.Toast;
using BusinessLogic.Definition;
using ProyectoEDI.Components;
using Microsoft.EntityFrameworkCore;
using ProyectoEDI.Backend;

var builder = WebApplication.CreateBuilder(args);

//  Mover configuraci�n de la base de datos antes de `Build()`
builder.Services.AddDbContext<ApplicationDBContext>(options =>
    options.UseSqlite("Data Source=ProyectoEdi.db"));


// Otros servicios
builder.Services.AddDevExpressBlazor();
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddScoped<MessageManager>();
builder.Services.AddBlazorBootstrap();
builder.Services.AddScoped<DataElementManager>();
var app = builder.Build();

//  Ejecutar migraciones autom�ticamente al iniciar la aplicaci�n
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDBContext>();
    dbContext.Database.Migrate();
}
// Configurar la aplicaci�n
app.UseHttpsRedirection();
app.UseStaticFiles();


app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
