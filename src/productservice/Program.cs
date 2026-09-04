using Azure.Identity;
using Microsoft.EntityFrameworkCore;
using productservice.data;
using System;

var builder = WebApplication.CreateBuilder(args);

// Azure Key Vault
builder.Configuration.AddAzureKeyVault(
    new Uri("https://cicdkeyvault111.vault.azure.net/"),
    new DefaultAzureCredential());

builder.Services.AddControllers();

// Entity Framework Core + SQL Server
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration["MohitSecretKey"],
        sqlOptions =>
        {
            sqlOptions.EnableRetryOnFailure(
                maxRetryCount: 5,
                maxRetryDelay: TimeSpan.FromSeconds(10),
                errorNumbersToAdd: null);
        }));

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Swagger
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();