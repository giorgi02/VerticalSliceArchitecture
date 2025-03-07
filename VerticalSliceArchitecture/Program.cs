using FastEndpoints;
using FastEndpoints.Swagger;
using Microsoft.EntityFrameworkCore;
using VerticalSliceArchitecture.Database;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

builder.Services.AddFastEndpoints();

builder.Services.AddOpenApi();
builder.Services.SwaggerDocument();

builder.Services.AddDbContext<DataContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DataContext")));

var app = builder.Build();
// Configure the HTTP request pipeline.

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseFastEndpoints();

app.UseSwaggerGen();

app.Run();
