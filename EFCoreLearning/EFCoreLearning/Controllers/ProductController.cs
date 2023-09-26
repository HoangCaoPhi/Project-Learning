using EFCoreLearning.BL.Interface;
using EFCoreLearning.Model;
using Microsoft.AspNetCore.Mvc;

namespace EFCoreLearning.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private IProductBL _productBL;

        public ProductController(IProductBL productBL)
        {
            _productBL = productBL;
        }

        [HttpPost("")]
        public async Task SaveProducts([FromBody] Product productInfo)
        {
            await _productBL.InsertData(productInfo);
        }

        [HttpGet("")]
        public async Task<object> GetProducts()
        {
            return await _productBL.GetProducts();
        }

        [HttpPut("")]
        public async Task<object> UpdateProductByID([FromBody] Product productInfo)
        {
            return await _productBL.UpdateProductByID(productInfo);
        }

        [HttpDelete("{productID}")]
        public async Task<object> DeleteProduct(int productID)
        {
            return await _productBL.DeleteProduct(productID);
        }
    }
}