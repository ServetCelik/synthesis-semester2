using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<LogicLayer.Interfaces.ITournamentDAL, DataAccessLayer.Classes.TournamentDAL>();
builder.Services.AddTransient<LogicLayer.Interfaces.IUserDAL, DataAccessLayer.Classes.UserDAL>();
builder.Services.AddSingleton<LogicLayer.LogicClasses.TournamentAdministrator>();
builder.Services.AddSingleton<LogicLayer.LogicClasses.UserAdministrator>();

// Add services to the container.
builder.Services.AddRazorPages();


builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(/*myAuthType, */options =>
{
    options.Cookie.Name =  "servet";    
    options.LoginPath = "/Index";
    options.AccessDeniedPath = "/Error";
});

builder.Services.AddDistributedMemoryCache();

builder.Services.AddAuthorization(option =>
{
    option.AddPolicy("MustBeHr", policy => policy.RequireClaim(ClaimTypes.Role, "HR"));
    option.AddPolicy("MustBeAdmin", policy => policy.RequireClaim(ClaimTypes.Role, "Admin"));    

    option.AddPolicy("MustBeStaff", policy => policy.RequireClaim("Position", "Staff"));   

});

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromSeconds(240);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true; ;
});





var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseSession();
app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();

app.Run();
