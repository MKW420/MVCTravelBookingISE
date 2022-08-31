using Microsoft.EntityFrameworkCore;
using MVCTravelBookingISE.Data;
<<<<<<< Updated upstream
=======
using Microsoft.AspNetCore.Identity;
//using MVCTravelBookingISE.Areas.Identity.Data;
>>>>>>> Stashed changes

var builder = WebApplication.CreateBuilder(args);

//var host = CreateHostBuilder(args).Build();

//using (var scope = host.Services.CreateScope())
//{
 //   var services = scope.ServiceProvider;

  // try
  // {
  //     var context = services.GetRequiredService<AppDbContext>();
   //   context.Database.Migrate();

  // }
  // catch(Exception ex)
  // {
//       var logger = services.GetRequiredService<ILogger<Program>>();
//        logger.LogError(ex, "An error occured creaing the DB.");
 ///   }
//}
//host.Run();
 
//public static IHostBuilder CreateHostBuilder(string[]args)=>
  //  Host.C


// Add services to the container.
builder.Services.AddControllersWithViews();

//DB context configiration
builder.Services.AddDbContext<AppDbContext>(options =>
<<<<<<< Updated upstream
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionString")));
=======
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultconnectionString")));

//AuthDB Contexr configuration
//builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
  //  .AddEntityFrameworkStores<AuthDbContext>();

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
>>>>>>> Stashed changes

//builder.Services.AddTransient<ICheckout, Checkout>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
