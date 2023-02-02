var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles(); // fichiers statics wwwroot

app.UseRouting(); // cré le bon controleur pour la bonne route

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// custom route
app.MapControllerRoute("customRoute", "test" , new { controller = "Home", action = "Index" } );
app.MapControllerRoute("customRoute", "person" , new { controller = "person", action = "personlist" } );

// route avec deux parametres
app.MapControllerRoute("customRouteArgs", "custom-person/{firstname}/{lastname}",
    new { controller = "person", action = "CustomDetail"} );

app.Run();
