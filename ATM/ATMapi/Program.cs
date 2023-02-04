using ATMapi.Config;
using ATMapi.DataAcces;
using ATMapi.Filters;
using ATMapi.Services;
using ATMapi.src;
using Microsoft.AspNetCore.Mvc;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Host.UseSerilog((ctx, lc) =>
lc.WriteTo.Console().ReadFrom.Configuration(ctx.Configuration));
builder.Services.Configure<ConfigurationModel>(builder.Configuration.GetSection("Config"));
builder.Services.Configure<ApiBehaviorOptions>(options => options.SuppressModelStateInvalidFilter = true);
builder.Services.AddScoped<ModelFilter>();
builder.Services.AddScoped<IReadData, ReadData>();
builder.Services.AddScoped<IModifyData, ModifyData>();
builder.Services.AddScoped<IGenerateRecipts, GenerateRecipts>();
builder.Services.AddScoped<ISoldAccountService, SoldAccountService>();
builder.Services.AddScoped<IDepositService,DepositService>();
builder.Services.AddScoped<IWithdrawService, WithdrawService>();
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
