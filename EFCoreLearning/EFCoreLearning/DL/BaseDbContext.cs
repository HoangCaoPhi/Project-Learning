using Microsoft.EntityFrameworkCore;

namespace EFCoreLearning.DL
{
    public class BaseDbContext : DbContext
    {
        private const string connectionString = "Server=localhost; User ID=root; Password=123456; Database=ef_learn";

        public static readonly ILoggerFactory loggerFactory = LoggerFactory.Create(builder =>
        {
            builder
                   .AddFilter(DbLoggerCategory.Database.Command.Name, LogLevel.Warning)
                   .AddFilter(DbLoggerCategory.Query.Name, LogLevel.Debug)
                   .AddConsole();
        });

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLoggerFactory(loggerFactory)
                .UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }
    }
}
