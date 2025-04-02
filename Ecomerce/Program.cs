using Ecomerce.Repositorios;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// INJEÇÃO DE DEPENDENCIA
// Colocando os intens da pasta Respositorio como dependencia

builder.Services.AddScoped<UsuarioRepositorio>();
builder.Services.AddScoped<ClienteRepositorio>();




var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
