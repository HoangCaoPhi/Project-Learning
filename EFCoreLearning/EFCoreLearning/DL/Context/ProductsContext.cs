using EFCoreLearning.Model;
using Microsoft.EntityFrameworkCore;

namespace EFCoreLearning.DL.Context
{
    public class ProductsContext : DbContext
    {
        // Thuộc tính products kiểu DbSet<Product> cho biết CSDL có bảng mà
        // thông tin về bảng dữ liệu biểu diễn bởi model Product
        public DbSet<Product> products { set; get; }

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
