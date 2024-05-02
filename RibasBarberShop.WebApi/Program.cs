using RibasBarberShop.Domain.Interfaces;
using RibasBarberShop.Domain.Interfaces.Base;
using RibasBarberShop.Domain.Services;
using RibasBarberShop.Infrastructure.Configuration;
using RibasBarberShop.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<SchedulingContext>();
builder.Services.AddSingleton(typeof(IBaseRepository<>), typeof(BaseRepository<>));
builder.Services.AddSingleton<IScheduledDateRepository, ScheduledDateRepository>();
builder.Services.AddSingleton<IScheduledDateService, ScheduledDateService>();
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

app.UseAuthorization();

app.MapControllers();

app.Run();
