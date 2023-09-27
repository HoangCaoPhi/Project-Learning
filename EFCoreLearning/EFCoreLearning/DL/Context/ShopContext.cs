
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

        public DbSet<User> users { set; get; }

        override protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Các Fluent API
            modelBuilder.Entity<User>(entity => {

                entity.ToTable("User");
                entity.HasKey(e => e.UserId);  // Thiết lập User.UserId là Pk
                entity.HasIndex(p => p.UserName)     // Đánh chỉ mục UserName (user_name)
                      .IsUnique(true);               // Unique


            });

            modelBuilder.Entity<Product>(entity => {
                // Thiết lập cho bảng Product
                entity.HasOne(e => e.UserPost)                      // Chỉ ra Entity là phía một (bảng User)
                      .WithMany(user => user.ProductsPost)         // Chỉ ra Collection tập Product lưu ở phía một
                      .HasForeignKey("UserPostId")                 // Chỉ ra tên FK nếu muốn
                      .OnDelete(DeleteBehavior.SetNull)            // Ứng xử khi User bị xóa (Hoặc chọn DeleteBehavior.Cascade)
                      .HasConstraintName("FK_Products_user_post"); // Tự đặt tên Constrain (dàng buốc)

            });
        }
    }
}
