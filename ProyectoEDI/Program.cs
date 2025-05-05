using ProyectoEDI.Components;
using ProyectoEDI.Components.Services;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddSingleton<MessageService>();
builder.Services.AddScoped<SegmentService>();
builder.Services.AddAntiforgery();

builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

// Configurar middleware
app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication(); // Si usas autenticación, debe ir antes de antiforgery
app.UseAuthorization();  // Si usas autorización, debe ir antes de antiforgery
app.UseAntiforgery();    // Agregar el middleware de antiforgery

app.MapRazorComponents<App>().DisableAntiforgery()
    .AddInteractiveServerRenderMode();

app.Run();
