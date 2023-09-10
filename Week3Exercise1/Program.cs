using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Week3Exercise1.Data;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<Week3Exercise1Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Week3Exercise1Context") ?? throw new InvalidOperationException("Connection string 'Week3Exercise1Context' not found.")));

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
