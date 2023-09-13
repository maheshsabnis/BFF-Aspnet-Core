using Com.BFF.Service.Domain;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
 
builder.Services.AddScoped<Logic>();
builder.Services.AddCors(options => options.AddPolicy("cors",
    policy => policy
    .AllowAnyHeader()
    .AllowAnyMethod()
    .AllowAnyOrigin()));
builder.Services.AddControllers()
     .AddJsonOptions(options=>options.JsonSerializerOptions.PropertyNamingPolicy=null);

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();
app.UseCors("cors");
app.UseAuthorization();

app.MapControllers();

app.Run();
