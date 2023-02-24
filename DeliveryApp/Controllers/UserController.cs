using API.Controllers.bases;
using API.DTOs.Users;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class UserController : APIControllerBase
    {
        private readonly IApplicationService _applicationService;

        public UserController(
           IApplicationService applicationService) : base(applicationService)
        {
            this._applicationService = applicationService;
        }

        [HttpPost]
        [Route("create-user")]
        public IActionResult CreateUser([FromForm] CreateUserRequest request)
        {
            try
            {
                var response = this._applicationService.CreateUser(request);
                return Success(response);
            }
            catch (Exception exc)
            {
                return this.BadRequest(exc.Message);
            }
        }

        [HttpGet]
        [Route("get-userbyid")]
        public IActionResult GetUserById(int id)
        {
            try
            {
                var response = this._applicationService.GetUserById(id);
                return Success(response);
            }
            catch (Exception exc)
            {
                return this.BadRequest(exc.Message);
            }
        }

        [HttpGet]
        [Route("get-userbyemail")]
        public IActionResult GetUserByEmail(string email)
        {
            try
            {
                var response = this._applicationService.GetUserByEmail(email);
                return Success(response);
            }
            catch (Exception exc)
            {
                return this.BadRequest(exc.Message);
            }
        }

        [HttpGet]
        [Route("get-validateuser")]
        public IActionResult ValidateUser([FromForm] ValidateUserRequest request)
        {
            try
            {
                var response = this._applicationService.ValidateUser(request);
                return Success(response);
            }
            catch (Exception exc)
            {
                return this.BadRequest(exc.Message);
            }
        }

        [HttpDelete]
        [Route("delete-userbyid")]
        public IActionResult DeleteUserById(int id)
        {
            try
            {
                var response = this._applicationService.DeleteUserById(id);
                return Success(response);
            }
            catch (Exception exc)
            {
                return this.BadRequest(exc.Message);
            }
        }

        [HttpPut]
        [Route("edit-user")]
        public IActionResult EditUser(EditUserInfoRequest request)
        {
            try
            {
                var response = this._applicationService.EditUserInfo(request);
                return Success(response);
            }
            catch (Exception exc)
            {
                return this.BadRequest(exc.Message);
            }
        }

    }
}
