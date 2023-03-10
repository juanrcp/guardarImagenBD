using EntityDAL;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

//AÑADIMOS EL SERVICIO PARA MOSTAR LA VISTA
builder.Services.AddDbContext<bD_ImagenDataContext>(options =>
    {
        options.UseNpgsql(builder.Configuration.GetConnectionString("EFCConexion"));
    });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
