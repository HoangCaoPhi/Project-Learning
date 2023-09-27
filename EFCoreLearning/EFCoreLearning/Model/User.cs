namespace EFCoreLearning.Model
{
    public class User
    {
        public int UserId { set; get; }

        public string UserName { set; get; }

        public List<Product> ProductsPost { set; get; }
    }
}
