
using API.Application.Services;
using API.Domain.Repository;
using API.Persistence.DataBase;
using API.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
namespace WorldCups_FiFa
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();
            builder.Services.AddDbContext<WorldCupsDB>(opt =>
            {
                opt.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
            });
            builder.Services.AddScoped<GroupsDbService>();
            builder.Services.AddScoped<IGroupsDbRepository, GroupsDbRepository>();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

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
