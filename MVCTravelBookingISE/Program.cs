using Microsoft.EntityFrameworkCore;
using MVCTravelBookingISE.Data;
using Microsoft.AspNetCore.Identity;

using Microsoft.Extensions.DependencyInjection.Extensions;
using MVCTravelBookingISE.Data.Services;
using MVCTravelBookingISE.Areas.Identity.Data;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.Extensions.Options;
using MVCTravelBookingISE.Data.Reservations;
using Microsoft.AspNetCore.Authorization;
using MVCTravelBookingISE.Authorization;
using ContactManager.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IAccomodationService, AccomodationService>();
builder.Services.AddScoped<ITransportService, TransportService>();
builder.Services.AddScoped<IFlightService, FlightService>();
builder.Services.AddScoped<IFlightRulesService, FlightRulesService>();


//Configure HTTP
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor > ();
builder.Services.AddScoped(br => BookingReserved.GetBookingCart(br));

builder.Services.AddMemoryCache();

builder.Services.AddSession();


// Add services to the container.
builder.Services.AddControllersWithViews();

//DB context configiration
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultconnectionString")));

builder.Services.AddDbContext<AuthDbContext>( options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AuthDbContextConnection")));


builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<AuthDbContext>()
    .AddDefaultTokenProviders();

builder.Services.AddMemoryCache();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(120);
}
    );



//services configuration

builder.Services.AddRazorPages();


builder.Services.AddAuthorization(options =>
{
    options.FallbackPolicy = new AuthorizationPolicyBuilder()
        .RequireAuthenticatedUser()
        .Build();
});


builder.Services.Configure<IdentityOptions>(options =>
{
    //Password settings
    options.SignIn.RequireConfirmedAccount = true;
    options.Password.RequireLowercase = true;
    options.Password.RequireNonAlphanumeric = true;
    options.Password.RequireUppercase = true;
    options.Password.RequiredLength = 6;
    options.Password.RequiredUniqueChars = 1;

    //Lockout settings
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
    options.Lockout.MaxFailedAccessAttempts = 5;
    options.Lockout.AllowedForNewUsers = true;

    //User settings

    options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
    options.User.RequireUniqueEmail = false;
});


builder.Services.ConfigureApplicationCookie(options =>
{
    options.Cookie.HttpOnly = true;
    options.ExpireTimeSpan = TimeSpan.FromMinutes(5);
    options.LoginPath = "/Identity/Account/Login";
    options.AccessDeniedPath = "/Identity/Account/AccessDenied";
    options.SlidingExpiration = true;
});


builder.Services.AddControllersWithViews();


var app = builder.Build();
//builder.Services.AddTransient<ICheckout, Checkout>();




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


app.MapControllerRoute(
 name: "default",
 pattern: "{controller=Home}/{action=Index}/{id?}");



//SEED DATABASE
SeedData.SeedRoles(app);
AppDbIntalizer.Seed(app);


app.Run();
