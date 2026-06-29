var builder = WebApplication.CreateBuilder(args);

builder.Logging.ClearProviders();
builder.Logging.AddConsole();

builder.Services.AddControllersWithViews();
builder.Services.AddAuthorization();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/about", () => "This is about page!");

app.Run();
