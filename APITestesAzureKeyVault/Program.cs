using FluentValidation;
using FluentValidation.AspNetCore;
using APITestesAzureKeyVault.Models;
using APITestesAzureKeyVault.Validators;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers().AddFluentValidation();

builder.Services.AddTransient<IValidator<ParametrosOperacao>, ParametrosOperacaoValidator>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
