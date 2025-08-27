var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<KODECAMP_TASK7.Services.AuthService>();
builder.Services.AddScoped<KODECAMP_TASK7.Services.StudentService>();
builder.Services.AddScoped<KODECAMP_TASK7.Services.TeacherService>();
builder.Services.AddScoped<KODECAMP_TASK7.Services.CourseService>();
builder.Services.AddScoped<KODECAMP_TASK7.Services.EnrollmentService>();
SchoolManagement.Controllers.JwtAuthenticationExtensions.AddJwtAuthentication(builder.Services, builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();


app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
