<<<<<<< HEAD
=======
using InterfocusConsole;

>>>>>>> 0e8221c2a7057d5e8f229c246c3327a289f5ed89
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

<<<<<<< HEAD
=======
builder.Services.AddTransient<AlunoService>();

>>>>>>> 0e8221c2a7057d5e8f229c246c3327a289f5ed89
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
