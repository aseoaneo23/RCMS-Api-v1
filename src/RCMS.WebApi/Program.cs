using Microsoft.OpenApi.Models;
using Microsoft.EntityFrameworkCore;
using RCMS.Application.Services;
using RCMS.Infrastructure;
using RCMS.Infrastructure.Interfaces;
using RCMS.Infrastructure.Persistance;
using RCMS.Infrastructure.Repositories;
using RCMS.Interfaces;
using RCMS.Mappers;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAutoMapper(typeof(Program).Assembly);

// Add services to the dependency injection container
builder.Services.AddScoped<IPartsRepository, PartsRepository>();
builder.Services.AddScoped<PartsMapper>();
builder.Services
    .AddScoped<IPartsService>(
        (serviceProvider) => new PartsService(
            serviceProvider.GetService<IPartsRepository>(),
            serviceProvider.GetService<PartsMapper>()
        ));


builder.Services.AddEndpointsApiExplorer();

builder.Services.Configure<AppSettings>(builder.Configuration.GetSection("ConnectionStrings"));

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "RCMS", Version = "v1", Description = "API for managing race components and related data"});
    c.AddSecurityDefinition("ApiKey", new OpenApiSecurityScheme
    {
        Description = "The API Key to access the API",
        Name = "x-api-key",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = "ApiKey"
    });

    var scheme = new OpenApiSecurityScheme
    {
        Reference = new OpenApiReference
        {
            Type = ReferenceType.SecurityScheme,
            Id = "ApiKey"
        },
        In = ParameterLocation.Header
    };
    var requirement = new OpenApiSecurityRequirement
    {
        { scheme, new List<string>() }
    };
    c.AddSecurityRequirement(requirement);
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "RCMS"); 
        c.RoutePrefix = "api-docs";
    });
}

app.UseHttpsRedirection();

app.UseRouting();

var environment = builder.Environment.EnvironmentName;
Console.WriteLine($"Entorno actual: {environment}");

// app.UseMiddleware<ApiKeyAuthMiddleware>();

app.UseAuthorization();

app.MapControllers();

app.Run();