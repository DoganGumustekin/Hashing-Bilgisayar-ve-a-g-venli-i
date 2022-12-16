using Autofac;
using Autofac.Extensions.DependencyInjection;
using Hashing2.Repos;
using Hashing2.Resolvers;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());

builder.Host.ConfigureContainer<ContainerBuilder>(builder => builder.RegisterModule(new Cozumleyiciler()));

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
//builder.Services.AddScoped<AuthRepo>();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
