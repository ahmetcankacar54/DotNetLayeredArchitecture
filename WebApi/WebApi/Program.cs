using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Mediator;
using Repository;
using Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Burada MigrationAssembly fonksiyonunu kullandim ancak su hatayi aliyorum "The given assembly name was invalid."  x => x.MigrationsAssembly("/Users/ahmetkacar/Projects/eCommerce/Data/Data/")//
builder.Services.AddDbContext<AppDbContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("NpsqlConnection")));
builder.Services.AddHttpContextAccessor();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddApplicationServices();           // Data servisleri burada baglaniyor
builder.Services.AddServiceServices();              // Service servisleri burada baglaniyor
builder.Services.AddRepositoryServices();  //Repository servisleri burada baglaniyor
builder.Services.AddCors(options =>
    options.AddDefaultPolicy(builder =>
        builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin()));

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "ECommerce API", Version = "v1" });
});

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Swagger");
});

app.UseCors();
app.Run();

