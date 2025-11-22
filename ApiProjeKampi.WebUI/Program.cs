using ApiProjeKampi.WebUI.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddHttpClient();
builder.Services.AddSignalR();
builder.Services.AddHttpClient("gemini", c =>
{
    //c.BaseAddress = new Uri("https://api.openai.com/");
    //c.BaseAddress = new Uri("https://api.gemini.com/"); // Gerçek Gemini endpointini buraya yaz
    c.BaseAddress = new Uri("https://generativelanguage.googleapis.com/");


});
//builder.Services.AddHttpClient("api", client =>
//{
//    client.BaseAddress = new Uri("https://localhost:7215/");
//});

builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.MapHub<ChatHub>("/chathub");
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
