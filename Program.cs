using Microsoft.EntityFrameworkCore;
using TaskApi.Context;
using TaskApi.ITaskRepository;
using TaskApi.Repo;

namespace TaskApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddTransient<ITask, TaskRepo>();

            builder.Services.AddDbContext<TaskDbContext>(x => x.UseSqlServer(builder.Configuration["ConnectionStrings:DBCS"]));

            // Add Required Dependencies here
            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}