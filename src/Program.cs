using Microsoft.VisualBasic;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    // serves the swagger UI at the app's root (url.com/index.html)
    options.RoutePrefix = string.Empty;
    //todo: why is it not workingg :(
    options.InjectStylesheet("/Assets/Swagger/custom.css");
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
