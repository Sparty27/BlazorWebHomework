using BlazorWebHomework.API.Filters;
using Serilog.Filters;

namespace MINT_WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            Log.Logger = new LoggerConfiguration()
                //.MinimumLevel.Debug()
                //.MinimumLevel.Override("Microsoft", Serilog.Events.LogEventLevel.Information)
                .Enrich.FromLogContext()

                .WriteTo.Console()
                .WriteTo.File("./Logs/log-.txt",
                    rollingInterval: RollingInterval.Day,
                    restrictedToMinimumLevel: Serilog.Events.LogEventLevel.Information)
                .WriteTo.File("./Logs/log-important-.txt",
                    rollingInterval: RollingInterval.Day,
                    restrictedToMinimumLevel: Serilog.Events.LogEventLevel.Warning)

                .Filter.ByExcluding("RequestPath = '/swagger/index.html'") // Exclude logs related to Swagger index
                .Filter.ByExcluding("RequestPath = '/_framework/aspnetcore-browser-refresh.js'") // Exclude logs related to aspnetcore-browser-refresh.js
                .Filter.ByExcluding("RequestPath = '/_vs/browserLink'")
                .Filter.ByExcluding("RequestPath = '/swagger/v1/swagger.json'")
                .CreateLogger();

            //builder.Host.UseSerilog();

            builder.Services.AddCors();
            builder.Services.AddControllers(options =>
            {
                options.Filters.Add(typeof(RequestInfoFilter));
            });
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            app.UseCors(builder => builder.AllowAnyOrigin()
                             .AllowAnyHeader()
                            .AllowAnyMethod());
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseAuthorization();


            app.MapControllers();

            app.Run();
            Log.CloseAndFlush();
        }
    }
}