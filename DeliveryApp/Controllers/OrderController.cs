using API.Controllers.bases;
using API.DTOs.Orders;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class OrderController : APIControllerBase
    {
        private readonly IApplicationService _applicationService;
        public OrderController(
         IApplicationService applicationService) : base(applicationService)
        {
            this._applicationService = applicationService;
        }

        [HttpPost]
        [Route("create-order")]
        public IActionResult CreateOrder([FromForm] CreateOrderRequest request)
        {
            try
            {
                var response = this._applicationService.CreateOrder(request);
                return Success(response);
            }
            catch (Exception exc)
            {
                return this.BadRequest(exc.Message);
            }
        }

        [HttpGet]
        [Route("get-orderbyid")]
        public IActionResult GetOrderById(int id)
        {
            try
            {
                var response = this._applicationService.GetOrderById(id);
                return Success(response);
            }
            catch (Exception exc)
            {
                return this.BadRequest(exc.Message);
            }
        }


        [HttpGet]
        [Route("get-allorders")]
        public IActionResult GetAllOrders()
        {
            try
            {
                var response = this._applicationService.GetAllOrders();
                return Success(response);
            }
            catch (Exception exc)
            {
                return this.BadRequest(exc.Message);
            }
        }

        [HttpDelete]
        [Route("delete-orderbyid")]
        public IActionResult DeleteOrderById(int id)
        {
            try
            {
                var response = this._applicationService.DeleteOrderById(id);
                return Success(response);
            }
            catch (Exception exc)
            {
                return this.BadRequest(exc.Message);
            }
        }

        [HttpPut]
        [Route("edit-order")]
        public IActionResult EditOrder(EditOrderRequest request)
        {
            try
            {
                var response = this._applicationService.EditOrderInfo(request);
                return Success(response);
            }
            catch (Exception exc)
            {
                return this.BadRequest(exc.Message);
            }
        }

    }
}
