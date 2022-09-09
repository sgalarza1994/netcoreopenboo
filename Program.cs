using CursoWebApi6.Database;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


var connection = "UniversityDb";

var connectionString  = builder.Configuration.GetConnectionString(connection);


builder.Services.AddDbContext<UniversityDb>
(options => {
   options.UseSqlServer(connectionString); 
});




// Add services to the container.

builder.Services.AddControllers();

//añadir los servicios

builder.Services.AddScoped<IStudentService,StudentService>();



// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//5 habilitar el cors configuration
builder.Services.AddCors(options => {
    options.AddPolicy(name: "CorsPolicy", builder =>
  {
      builder.AllowAnyOrigin();
      builder.AllowAnyMethod();
      builder.AllowAnyHealder();
  });

});



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

// 6. Haga uso del cors
app.UseCors("CorsPolicy");
app.Run();
