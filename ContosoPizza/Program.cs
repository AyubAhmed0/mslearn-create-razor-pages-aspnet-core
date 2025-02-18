// This file is the entry point of your ASP.NET Core application. 
// It sets up the services (like database and Razor Pages), middleware (like routing and error handling),
// and starts the application.
using ContosoPizza.Data;  // Importing the namespace that contains the database context (PizzaContext).
using ContosoPizza.Services;  // Importing the namespace that contains the business logic (PizzaService).
using Microsoft.EntityFrameworkCore;  // Importing Entity Framework Core for database operations.

var builder = WebApplication.CreateBuilder(args);  
// Creates a web application builder to configure the app and its services.

// =============================
// Add services to the DI container
// =============================

builder.Services.AddRazorPages();  
// Registers Razor Pages, allowing the app to use .cshtml pages for the UI.

builder.Services.AddDbContext<PizzaContext>(options =>  
    options.UseSqlite("Data Source=ContosoPizza.db"));  
// Registers the database context (PizzaContext) and configures it to use SQLite with the specified database file.

builder.Services.AddScoped<PizzaService>();  
// Registers PizzaService with "scoped" lifetime:
// - A new instance is created per HTTP request
// - It ensures efficient use of database operations

var app = builder.Build();  
// Builds the application with the configured services.

// =============================
// Configure the HTTP request pipeline
// =============================

if (!app.Environment.IsDevelopment())  
{
    app.UseExceptionHandler("/Error");  
    // In production mode, errors are handled by redirecting to the "/Error" page.

    app.UseHsts();  
    // Enables HTTP Strict Transport Security (HSTS) to enforce secure connections (HTTPS).
}

app.UseHttpsRedirection();  
// Redirects all HTTP requests to HTTPS for security.

app.UseStaticFiles();  
// Enables serving static files (CSS, JavaScript, images, etc.) from the wwwroot folder.

app.UseRouting();  
// Enables request routing, which determines how URLs map to pages.

app.UseAuthorization();  
// Enables authorization middleware (though no specific rules are defined yet).

app.MapRazorPages();  
// Maps Razor Pages so that users can access them via URLs.

app.Run();  
// Starts the web application and begins listening for incoming requests.

