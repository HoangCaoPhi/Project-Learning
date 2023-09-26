using EFCoreLearning.BL.Interface;
using EFCoreLearning.DL.Context;
using EFCoreLearning.Model;
using Microsoft.EntityFrameworkCore;

namespace EFCoreLearning.BL
{
    public class ProductBL : IProductBL
    {
        public async Task InsertData(Product productInfo)
        {
            using var context = new ProductsContext();

            await context.products.AddAsync(new Product
            {
                Name = productInfo.Name,
                Provider = productInfo.Provider
            });

            int rows = await context.SaveChangesAsync();
        }

        public async Task<object> GetProducts()
        {
            using var context = new ProductsContext();

            var products = await context.products.ToListAsync();

            return products;
        }

        public async Task<int> UpdateProductByID(Product productInfo)
        {
            using var context = new ProductsContext();

            var product = await (from p in context.products where (p.ProductId == productInfo.ProductId) select p).FirstOrDefaultAsync();

            if (product != null)
            {
                product.Name = productInfo.Name;
                product.Provider = productInfo.Provider;
                return await context.SaveChangesAsync();
            }

            return 0;
        }

        public async Task<int> DeleteProduct(int productID)
        {
            using var context = new ProductsContext();

            var product = await (from p in context.products where (p.ProductId == productID) select p).FirstOrDefaultAsync();

            if (product != null)
            {
                context.Remove(product);
                return await context.SaveChangesAsync();
            }

            return 0;
        }
    }
}
