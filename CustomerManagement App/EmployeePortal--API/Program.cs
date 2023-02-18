using EmployeePortal__API.BusinessLogic.Filters;
using EmployeePortal__API.Config;
using EmployeePortal__API.DataAcces.ModifyData.DeleteData;
using EmployeePortal__API.DataAcces.ModifyData.InsertData;
using EmployeePortal__API.DataAcces.ModifyData.UpdateData;
using EmployeePortal__API.DataAcces.ReadData;
using EmployeePortal__API.Persistence;
using EmployeePortal__API.Services;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.Configure<ConfigurationModel>(builder.Configuration.GetSection("Config"));
builder.Host.UseSerilog((ctx, lc) =>
lc.WriteTo.Console().ReadFrom.Configuration(ctx.Configuration));
builder.Services.AddScoped<ModelValidationFilter>();
builder.Services.AddScoped<IReadAccountData, ReadAccountData>();
builder.Services.AddScoped<IReadCustomerData, ReadCustomerData>();
builder.Services.AddScoped<IInfoService, InfoService>();
builder.Services.AddScoped<IUpdateData, UpdateData>();
builder.Services.AddScoped<IInsertData, InsertData>();
builder.Services.AddScoped<IDeleteData, DeleteData>();
builder.Services.AddScoped<ICreateDataService, CreateDataService>();
builder.Services.AddScoped<IDeleteDataService, DeleteDataService>();
builder.Services.AddScoped<IUpdateDataService, UpdateDataService>();
builder.Services.AddScoped<IFunctionsService, FunctionsService>();
builder.Services.AddScoped<IGenerateStatement, GenerateStatement>();


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
