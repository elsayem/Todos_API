
using Microsoft.EntityFrameworkCore;
using TodoList.DAL.Data.Context;
using TodoList.DAL.Repos;

namespace Todo_List_Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();

            //Adding SQL Connection String:
            builder.Services.AddDbContext<TodosContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("TodosConnectionString"));
            });

            //register survice to implement DI:
            builder.Services.AddScoped<ITodoRepo, TodoRepo>();

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


            app.MapControllers();

            app.Run();
        }
    }
}
