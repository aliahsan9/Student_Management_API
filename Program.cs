using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;
using Student_Management_API.Data;
using Student_Management_API.Interfaces;
using Student_Management_API.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Configure Database Here
builder.Services.AddDbContext<AppDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add services to the container.

// Repositories
builder.Services.AddScoped<IStudent, StudentRepository>();

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
