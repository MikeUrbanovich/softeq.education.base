using System.Reflection;
using FluentValidation;
using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using TrialsSystem.UsersService.Api.Application.Validation;
using TrialsSystem.UsersService.Api.Filters;
using TrialsSystem.UsersService.Infrastructure.Configuration;
using TrialsSystem.UsersService.Infrastructure.Context;
using TrialsSystem.UsersService.Infrastructure.Mapping;

namespace TrialsSystem.UsersService.Api
{
    /// <summary>
    /// 
    /// </summary>
    public class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services
                .AddDbContext<UsersServiceContext>(options =>
                    options.UseSqlServer(builder.Configuration.GetConnectionString("UsersContextConnection")));

            builder.Services.AddControllers();

            builder.Services.AddFluentValidationAutoValidation();

            builder.Services.AddValidatorsFromAssemblyContaining<EditUserRequestValidator>();
            builder.Services.AddValidatorsFromAssemblyContaining<CreateUserRequestValidator>();
            builder.Services.AddValidatorsFromAssemblyContaining<CreateDeviceRequestValidator>();
            builder.Services.AddValidatorsFromAssemblyContaining<CreateCityRequestValidator>();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();

            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1",
                    new OpenApiInfo { Title = "TrialsSystem.UsersService", Version = "v1" }
                );
                var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                c.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
            });

            builder.Services.AddMediatR(Assembly.GetExecutingAssembly());
            builder.Services.AddAutoMapper(mc => mc.AddProfile(new MappingProfile()));

            builder.Services.AddScoped<UserExceptionFilter>();
            builder.Services.AddScoped<CityExceptionFilter>();
            builder.Services.AddScoped<DeviceExceptionFilter>();

            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

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
        }
    }
}