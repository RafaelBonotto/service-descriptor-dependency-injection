using ServiceDescriptor.Interfaces;
using ServiceDescriptor.Services;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// Definindo ServiceTwo para implementação da interface
var descriptor = new Microsoft.Extensions.DependencyInjection.ServiceDescriptor(
    typeof(IService),
    typeof(ServiceTwo),
    ServiceLifetime.Transient);

builder.Services.Add(descriptor);
    

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
