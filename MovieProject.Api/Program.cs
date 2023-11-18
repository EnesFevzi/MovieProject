using MovieProject.Service.Entensions;
using MovieProject.DataAccess.Extensions;
using FluentValidation.AspNetCore;
using MovieProject.Service.FluentValidations;
using System.Globalization;
using System.Text.Json.Serialization;

namespace MovieProject.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.LoadDataLayerExtension(builder.Configuration);
            builder.Services.LoadServiceLayerExtension();
            builder.Services.AddControllersWithViews()
               .AddFluentValidation(opt =>
               {
                   opt.RegisterValidatorsFromAssemblyContaining<FilmAddDtoValidator>();
                   opt.DisableDataAnnotationsValidation = true;
                   opt.ValidatorOptions.LanguageManager.Culture = new CultureInfo("tr");
               }).AddJsonOptions(options =>
               {
                   options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;
                   options.JsonSerializerOptions.MaxDepth = 64; // veya istediðiniz bir derinlik deðeri
               });
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowLocalhost",
                    builder =>
                    {
                        builder.WithOrigins() 
                               .AllowAnyHeader()
                               .AllowAnyMethod();
                    });
            });
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

            app.UseCors("AllowLocalhost");
            app.MapControllers();

            app.Run();
        }
    }
}