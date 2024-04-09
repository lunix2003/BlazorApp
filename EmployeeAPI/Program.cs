using ClassLibrary;
using EmployeeAPI;
using EmployeeAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>();
builder.Services.AddCors(setup =>
{
    setup.AddPolicy("Allow", p =>
    {
        p.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
    });
});
//Mapper
builder.Services.AddAutoMapper(typeof(MapperConfiguration));
builder.Services.AddScoped<IAuthorService, AuthorServiceImp>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.MapGet("/Employees", (HttpContext http) =>
//{

//});
app.UseHttpsRedirection();

app.UseAuthorization();
app.UseCors("Allow");

app.MapControllers();

app.Run();
