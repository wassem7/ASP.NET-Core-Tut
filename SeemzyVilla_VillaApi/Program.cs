using SeemzyVilla_VillaApi.Logging;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//Log.Logger = new LoggerConfiguration()
//    .MinimumLevel
//    .Debug()
//    .WriteTo
//    .File("/logs/villaLogs.txt", rollingInterval: RollingInterval.Day)
//    .CreateLogger();

//builder.Host.UseSerilog();
builder.Services.AddControllers().AddNewtonsoftJson();
builder.Services.AddSingleton<ILogging, Logging>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
