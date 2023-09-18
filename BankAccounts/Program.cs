using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BankAccounts.Data;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<BankAccountsContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("BankAccountsContext") ?? throw new InvalidOperationException("Connection string 'BankAccountsContext' not found.")));

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
