using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreLearning.Model
{
    [Table("Products")]
    public class Product
    {
        [Key]
        public int ProductId { set; get; }

        [Required]
        [StringLength(50)]
        public string Name { set; get; }

        [StringLength(50)]
        public string Provider { set; get; }

        public virtual Category Category { set; get; }

        public int? CategoryID { set; get; }

        public int? UserPostId { set; get; }         // Lưu thông tin người Post sản phẩm

        public virtual User UserPost { set; get; }    // Tham chiếu User
    }
}
