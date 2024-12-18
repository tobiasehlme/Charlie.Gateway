using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);

// Add Ocelot configuration (load ocelot.json)
builder.Configuration.AddJsonFile("ocelot.json", optional: false, reloadOnChange: true);

// Register Ocelot services
builder.Services.AddOcelot();

// Add health checks service
builder.Services.AddHealthChecks();

// Configure logging for debugging purposes
builder.Logging.AddConsole();
builder.Logging.SetMinimumLevel(LogLevel.Debug);

var app = builder.Build();

// Map health check endpoint for Ocelot API Gateway
app.MapHealthChecks("/healthz");

// Use Ocelot middleware to handle the API Gateway routing
app.UseOcelot().Wait();

// Run the application
app.Run();