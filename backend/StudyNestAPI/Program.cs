using StudyNestAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add the services
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddOpenApi();

// Register the services
builder.Services.AddSingleton<ExcelService>();

var app = builder.Build();

// Configures  HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

// Enables Controllers
app.MapControllers();

app.Run();