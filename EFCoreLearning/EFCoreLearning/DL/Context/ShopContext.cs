
using EFCoreLearning.Model;
using Microsoft.EntityFrameworkCore;

namespace EFCoreLearning.DL.Context
{
    public class ShopContext : BaseDbContext
    {
        // Thuộc tính products kiểu DbSet<Product> cho biết CSDL có bảng mà
        // thông tin về bảng dữ liệu biểu diễn bởi model Product
        public DbSet<Product> products { set; get; }      // bảng Products
        public DbSet<Category> categories { set; get; }   // bảng Category
    }
}
