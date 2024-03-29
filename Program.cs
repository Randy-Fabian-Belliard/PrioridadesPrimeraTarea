using PrioridadesPrimeraTarea.Components;
using Microsoft.EntityFrameworkCore;
using PrioridadesPrimeraTarea.DAL;
using PrioridadesPrimeraTarea.BLL;

var builder = WebApplication.CreateBuilder(args);
var ConStr = builder.Configuration.GetConnectionString("ConStr");
builder.Services.AddDbContext<Contexto>(opcion => opcion.UseSqlite(ConStr));
 builder.Services.AddScoped<PrioridadesBLL>();
builder.Services.AddScoped<ClientesBLL>();
builder.Services.AddScoped<SistemasServices>();
builder.Services.AddScoped<TicketsServices>();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
