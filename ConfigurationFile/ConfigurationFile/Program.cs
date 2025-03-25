using ConfigurationFile;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped<ITestConfiguration, TestConfiguration>();

builder.Services.Configure<EmailSettings>(
     builder.Configuration.GetSection("EmailSettings")
    );

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
