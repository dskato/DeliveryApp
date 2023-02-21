using API.Controllers.bases;
using API.DTOs.Products;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class ProductController : APIControllerBase
    {
        private readonly IApplicationService _applicationService;
        public ProductController(
         IApplicationService applicationService) : base(applicationService)
        {
            this._applicationService = applicationService;
        }

        [HttpPost]
        [Route("create-product")]
        public IActionResult CreateProduct([FromForm] CreateProductRequest request)
        {
            try
            {
                var response = this._applicationService.CreateProduct(request);
                return Success(response);
            }
            catch (Exception exc)
            {
                return this.BadRequest(exc.Message);
            }
        }

        [HttpGet]
        [Route("get-productbyid")]
        public IActionResult GetProductById(int id)
        {
            try
            {
                var response = this._applicationService.GetProductById(id);
                return Success(response);
            }
            catch (Exception exc)
            {
                return this.BadRequest(exc.Message);
            }
        }

        [HttpDelete]
        [Route("delete-productbyid")]
        public IActionResult DeleteProductById(int id)
        {
            try
            {
                var response = this._applicationService.DeleteProductById(id);
                return Success(response);
            }
            catch (Exception exc)
            {
                return this.BadRequest(exc.Message);
            }
        }

        [HttpPut]
        [Route("edit-product")]
        public IActionResult EditProduct(EditProductRequest request)
        {
            try
            {
                var response = this._applicationService.EditProductInfo(request);
                return Success(response);
            }
            catch (Exception exc)
            {
                return this.BadRequest(exc.Message);
            }
        }
    }
}
