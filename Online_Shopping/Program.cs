var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
   
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "About",
    pattern: "{controller=About}/{action=Index}/{id?}");
app.MapControllerRoute(
    name: "ContactUs",
    pattern: "{controller=Contact}/{action=Index}/{id?}");
app.MapControllerRoute(
    name: "Products",
    pattern: "{controller=Products}/{action=Index}/{id?}");

app.Run();
