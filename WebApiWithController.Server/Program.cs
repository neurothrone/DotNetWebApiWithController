using Microsoft.EntityFrameworkCore;
using WebApiWithController.Persistence.EFCore.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<HeroDbContext>(options =>
    {
        options.UseSqlServer(
            builder.Configuration.GetConnectionString(nameof(HeroDbContext)) ?? throw new InvalidOperationException(
                $"Connection string '{nameof(HeroDbContext)}' not found.")
        );

#if DEBUG
        options.EnableSensitiveDataLogging();
#endif
    }
);

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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();