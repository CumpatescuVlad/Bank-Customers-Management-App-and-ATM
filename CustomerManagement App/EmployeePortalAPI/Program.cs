using EmployeePortalAPI.BusinessLogic.Filters;
using EmployeePortalAPI.Config;
using EmployeePortalAPI.DataAcces;
using EmployeePortalAPI.DataAcces.CustomerData;
using EmployeePortalAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.Configure<ApiBehaviorOptions>(options => options.SuppressModelStateInvalidFilter = true);
builder.Host.UseSerilog((ctx,lc)=>
lc.WriteTo.Console().ReadFrom.Configuration(ctx.Configuration));
builder.Services.Configure<ConfigModel>(builder.Configuration.GetSection("Config"));
builder.Services.AddScoped<ModelValidationFilter>();
builder.Services.AddScoped<IReadData, ReadCustomerData>();
builder.Services.AddScoped<IValidationService, ValidationService>();
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
