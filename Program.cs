using DependcyInjection.Entities;
using DependcyInjection.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<ITeacher>(sp => new Teacher("Serhan", "Y�ld��rm"));// we use the defined for the result
builder.Services.AddControllers();
// Add services to the container.

builder.Services.AddControllers();
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
