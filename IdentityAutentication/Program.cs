using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using IdentityAutentication.Areas.Identity.Data;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("IdentityAutenticationDBContextConnection") ?? throw new InvalidOperationException("Connection string 'IdentityAutenticationDBContextConnection' not found.");

builder.Services.AddDbContext<IdentityAutenticationDBContext>(options =>
    options.UseSqlServer(connectionString));



// NEED TO WRITE
// --- options.SignIn.RequireConfirmedAccount = false

builder.Services.AddDefaultIdentity<AutenticationUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddEntityFrameworkStores<IdentityAutenticationDBContext>();





// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();;

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");



// ---------- Call this 
// ---------- For Login and Registration (_LoginPartial)
app.MapRazorPages();



app.Run();
