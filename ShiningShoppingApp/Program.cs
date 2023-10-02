using ShiningShoppingApp.Context;
using Microsoft.EntityFrameworkCore;
using ShiningShoppingApp.Repository;
using ShiningShoppingApp.Interfaces;
using ShiningShoppingApp.Models;
using ShiningShoppingApp.Services;

namespace ShiningShoppingApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            
            builder.Services.AddDbContext<UserContext>(opts =>
            {

                opts.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));

            });
            builder.Services.AddScoped<IUserService, UserService>();
            builder.Services.AddScoped<IProductService,ProductService>();

            builder.Services.AddScoped<IUserRepo<string, Login>, UserRepo>();
            builder.Services.AddScoped<IProductRepo<int, Product>, ProductRepo>();
           
builder.Services.AddControllersWithViews().AddNewtonsoftJson(options =>
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
);
            // Add services to the container
            builder.Services.AddControllers();

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

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}