using DefaultNamespace;
using Microsoft.EntityFrameworkCore;
using MySqlConnector;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var mySqlConnectionBuilder = new MySqlConnectionStringBuilder()
{
    Server = "localhost",
    Database = "stocks",
    UserID = "root",
    Password = "password123",
    Port = 50852
};

var serverVersion = ServerVersion.AutoDetect(mySqlConnectionBuilder.ConnectionString);

builder.Services.AddDbContext<StocksDbContext>(options =>
    options.UseMySql(mySqlConnectionBuilder.ConnectionString, serverVersion));

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

app.MapGet("/getStocks", ()=> Results.Ok(new user("sofi", "Bha2712")));

app.Run();

public partial class Program { }

record user (string Name, string MemberID);






