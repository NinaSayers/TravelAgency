using Microsoft.EntityFrameworkCore;
using TravelAgency.Application;
using TravelAgency.Domain;
using TravelAgency.Infrastructure;

using Microsoft.EntityFrameworkCore;
using TravelAgency.Application;
using TravelAgency.Domain;
using TravelAgency.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var services = builder.Services;

services.AddHttpContextAccessor();
services.AddApplicationServices();
services.AddInfraestructureServices(builder.Configuration);
services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyHeader()
               .AllowAnyMethod();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    await app.InitializeDatabaseAsync();
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors();
app.UseCors();
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

 app.MapControllers();
 
   
app.UseAuthentication();
app.UseAuthorization();

 app.MapControllers();
 
   
app.Run();

