using Microsoft.EntityFrameworkCore;
using mirea_vetclinic.Domain;
using mirea_vetclinic.Domain.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<VetClinicContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("mirea-vetclinic"));
    options.UseSnakeCaseNamingConvention();
});
builder.Services.AddScoped<IOwnerRepository, OwnerRepository>();

builder.Services.AddRouting(options => options.LowercaseUrls = true);

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