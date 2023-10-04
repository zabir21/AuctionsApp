using Auctions.Application;
using Auctions.Application.Behaviours;
using Auctions.Application.Mediators;
using Auctions.Database.Auctions;
using Auctions.Database.Bets;
using Auctions.Database.Lots;
using Auctions.Domain;
using AuctionsApp;
using MediatR;

var builder = WebApplication.CreateBuilder(args);

var assemblies = AppDomain.CurrentDomain.GetAssemblies();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMediatR(config =>
{
    config.Lifetime = ServiceLifetime.Scoped;
    config.RegisterServicesFromAssemblies(assemblies);
});

builder.Services.AddSingleton<IRepository<Auction>, InMemoryAuctionsRepository>();
builder.Services.AddSingleton<IRepository<Lot>, InMemoryLotsRepository>();
builder.Services.AddSingleton<IRepository<Bet>, InMemoryBetsRepository>();
builder.Services.AddSingleton<UnitOfWork>();

var openGenericType = typeof(IValidator<>);
var types = assemblies
    .SelectMany(a => a
        .GetTypes()
        .Where(t => !t.IsAbstract && !t.IsGenericTypeDefinition));

foreach (var type in types)
{
    var validatorInterface = type
        .GetInterfaces()
        .FirstOrDefault(t => t.IsGenericType && t.GetGenericTypeDefinition() == openGenericType);

    if (validatorInterface != null)
        builder.Services.AddSingleton(validatorInterface, type);
}

builder.Services.AddScoped(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));

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
