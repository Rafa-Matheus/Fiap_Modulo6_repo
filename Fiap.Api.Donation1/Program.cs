using Fiap.Api.Donation1.Data;
using Fiap.Api.Donation1.Repository;
using Fiap.Api.Donation1.Repository.Interface;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Para configurar o banco e indicar a classe de contexto do banco. Decorar/Entender...
var connectionString = builder.Configuration.GetConnectionString("databaseUrl");
builder.Services.AddDbContext<DataContext>(
        options => options.UseSqlServer(connectionString).EnableSensitiveDataLogging(true)
    );

builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
builder.Services.AddScoped<ITipoProdutoRepository, TipoProdutoRepository>();


#region Autenticação

var key = Encoding.ASCII.GetBytes("d98193f6 - 0c56 - 43e1 - 954a - 6efd41baed87");

builder.Services.AddAuthentication(a =>
{
    a.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    a.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}
    ).AddJwtBearer(options =>
    {
        options.RequireHttpsMetadata = false;
        options.SaveToken = true;
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            ValidateIssuer = false,
            IssuerSigningKey = new SymmetricSecurityKey(key),
            // LifeTimeValidator = ...,
            ValidateAudience = false,
            ValidateLifetime = true,
            RequireExpirationTime = true
        };
    });
#endregion


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
