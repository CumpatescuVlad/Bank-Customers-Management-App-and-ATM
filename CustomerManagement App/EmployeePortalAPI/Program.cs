using EmployeePortalAPI.DataAcces.ModifyData.DeleteData;
using EmployeePortalAPI.DataAcces.ModifyData.InsertData;
using EmployeePortalAPI.DataAcces.ModifyData.UpdateData;
using EmployeePortalAPI.DataAcces.ReadData;
using EmployeePortalAPI.BusinessLogic.Filters;
using EmployeePortalAPI.Services;
using EmployeePortalAPI.Config;
using Microsoft.AspNetCore.Mvc;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.Configure<ApiBehaviorOptions>(options => options.SuppressModelStateInvalidFilter = true);
builder.Services.Configure<ConfigurationModel>(builder.Configuration.GetSection("Config"));
builder.Host.UseSerilog((ctx, lc) =>
lc.WriteTo.Console().ReadFrom.Configuration(ctx.Configuration));
builder.Services.AddScoped<ModelValidationFilter>();
builder.Services.AddScoped<IReadCustomerData, ReadCustomerData>();
builder.Services.AddScoped<IReadAccountData, ReadAccountData>();
builder.Services.AddScoped<IInfoService, InfoService>();
builder.Services.AddScoped<IUpdateData,UpdateData>();
builder.Services.AddScoped<IInsertData,InsertData>();
builder.Services.AddScoped<IDeleteData,DeleteData>();
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

