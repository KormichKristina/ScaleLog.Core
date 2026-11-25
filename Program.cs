
using Infrastructure;
using Infrastructure.SnakeCard;
using SnakeCards.CreateSnakeCard;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSwaggerGen();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddMediatR(param=>
    param.RegisterServicesFromAssembly(typeof(Program).Assembly));
builder.Services.AddScoped<ISnakeCardRepository,SnakeCardRepository>();
builder.Services.AddScoped<ISqlResourceHelper,SqlResourceHelper>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapCreateSnakeCard();

app.Run();
