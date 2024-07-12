using GestaoConta.Domain.Contracts.Infrastructure;
using GestaoConta.Domain.Contracts.UserCase;
using GestaoConta.Infrastructure;
using GestaoConta.UserCase;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IGestaoContaDbContext, GestaoContaDbContext>();
builder.Services.AddScoped<IGestaoContaUserCase, GestaoContaUserCase>();

// Add services to the container.

builder.Services.AddControllers();
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

app.UseAuthorization();

app.MapControllers();

app.Run();
