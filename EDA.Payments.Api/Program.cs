using System.ComponentModel.DataAnnotations;
using EDA.Payments.Api.DTOs;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();
app.MapControllers();

app.Run();
