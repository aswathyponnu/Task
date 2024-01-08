using Microsoft.EntityFrameworkCore;
using TaskAPI.BI;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ITaskRepository, TaskRepository>();


var app = builder.Build();




//builder.Services.AddDbContext<TaskDbContext>(options =>
//{
//    //The name of the connection string is taken from appsetting.json under ConnectionStrings
//    options.UseSqlServer(builder.Configuration.GetConnectionString("DatabaseDBConnString"));
//});


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
