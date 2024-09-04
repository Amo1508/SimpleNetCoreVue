using SimpleNetCoreVue.DiExtension;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddOpenApiDocument();
builder.Services.AddApCommands();

var app = builder.Build();
app.UseHttpsRedirection();
app.UseStaticFiles();

// in Development
if (app.Environment.IsDevelopment())
{
    app.UseOpenApi();
    app.UseSwaggerUi();
}

app.UseRouting();
app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html");

app.Run();