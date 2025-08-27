using System;
using Microsoft.EntityFrameworkCore;
using SchoolManagement.Data;
using SchoolManagement.Models;
using SchoolManagement.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;

class Program
{
    static void Main(string[] args)
    {
        
        var (teacher, student, engineering, geometry) = SchoolInitializer.Initialize();

        // Output
        Console.WriteLine($"Student: {student.FullName} ({student.Email})");
        Console.WriteLine($"DOB: {student.DateOfBirth.ToShortDateString()}, Gender: {student.Gender}");
        Console.WriteLine("Enrolled Courses:");

        foreach (var enrollment in student.Enrollments)
        {
            Console.WriteLine($" - {enrollment.Course.Title} ({enrollment.Course.Description})");
            Console.WriteLine($"   Taught by: {enrollment.Course.Teacher.FullName} | Grade: {enrollment.Grade}");
        }

        var builder = WebApplication.CreateBuilder(args);

        // Configure EF Core
        builder.Services.AddDbContext<SchoolDbContext>(options =>
            options.UseSqlServer(builder.Configuration["ConnectionStrings:DefaultConnection"]));

        // Add controllers
        builder.Services.AddControllers();

        // Add JWT authentication
        SchoolManagement.Controllers.JwtAuthenticationExtensions.AddJwtAuthentication(builder.Services, builder.Configuration);

        var app = builder.Build();

        // Use authentication and authorization
        app.UseAuthentication();
        app.UseAuthorization();

        // Map controllers
        app.MapControllers();

        app.Run();
    }
}
