using ConfigOptionsDemo.Models;
using ConfigOptionsDemo.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);


builder.Services.AddHostedService<JobService>();
builder.Services.AddScoped<MongoContext>();
builder.Services.AddSingleton<SqlContext>();

builder.Services.Configure<SqlSettings>(builder.Configuration.GetSection("ConnectionStrings"));
builder.Services.Configure<CronValuesSettings>(builder.Configuration.GetSection("CronValues"));
builder.Services.Configure<MongoDbSettings>(builder.Configuration.GetSection("MongoDb"));

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
