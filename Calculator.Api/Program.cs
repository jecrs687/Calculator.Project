using Calculator.Api.Extensions;
using Calculator.Api.Filters;

var builder = WebApplication.CreateBuilder(args);






builder.Services
    .AddServices()
    .AddControllers(
        options =>
        {
            options.Filters.Add(new GlobalExceptionFilter());
            options.Filters.Add(new GlobalActionFilter());

        }
    );
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