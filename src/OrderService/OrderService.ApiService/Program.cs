using Microsoft.AspNetCore.Http.HttpResults;

using OrderService.ApiService.Interfaces;
using OrderService.ApiService.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddProblemDetails();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();

var app = builder.Build();
app.UseExceptionHandler();


app.MapGet("/orders", () =>
{
    return Results.Ok();
});

app.MapPost("/orders", () =>
{
    return Results.Ok();
});


app.Run();
