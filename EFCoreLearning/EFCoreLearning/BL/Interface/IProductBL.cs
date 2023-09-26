using EFCoreLearning.Model;

namespace EFCoreLearning.BL.Interface
{
    public interface IProductBL
    {
        Task InsertData(Product productInfo);

        Task<object> GetProducts();

        Task<int> UpdateProductByID(Product productInfo);

        Task<int> DeleteProduct(int productID);
    }
}
