using CardDeckGame.Server.Extensions;
using Contracts;
using Microsoft.AspNetCore.HttpOverrides;
using NLog;

var builder = WebApplication.CreateBuilder(args);

LogManager.LoadConfiguration(string.Concat(Directory.GetCurrentDirectory(),
"/nlog.config"));

builder.Services.ConfigureCors();
builder.Services.ConfigureIISIntegration();
builder.Services.ConfigureLoggerService();
builder.Services.ConfigureRepositoryManager();
builder.Services.ConfigureServiceManager();
builder.Services.ConfigureSqlContext(builder.Configuration);
builder.Services.AddAutoMapper(typeof(Program)); // <---- Injektar AutoMapper i program
builder.Services.ConfigureSwagger(); // <--- Drar ig�ng Swagger

builder.Services.AddControllers()
    .AddApplicationPart(typeof(CardDeckGame.Presentation.AssemblyReference).Assembly); // <----- H�mtar controllers fr�n CardDeckGame.Presentation.

var app = builder.Build();

var logger = app.Services.GetRequiredService<ILoggerManager>(); // <----- H�mtar och k�r Loggern
app.ConfigureExceptionHandler(logger);

if (app.Environment.IsProduction())
    app.UseHsts();

app.UseSwagger();
app.UseSwaggerUI(s =>
{
    s.SwaggerEndpoint("/swagger/v1/swagger.json", "Card Deck Game API v1");
    s.SwaggerEndpoint("/swagger/v2/swagger.json", "Card Deck Game API v2");
});


app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseForwardedHeaders(new ForwardedHeadersOptions
{
    ForwardedHeaders = ForwardedHeaders.All
});

app.UseCors("CorsPolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();
