using API.DTOs.Users;
using Domain.Entities;

namespace API
{
    public partial class ApplicationService : IApplicationService
    {
        public CreateUserResponse CreateUser(CreateUserRequest request)
        {
            CreateUserResponse response = new CreateUserResponse();
            UserEntity entity = new UserEntity();

            entity.Email = request.Email;
            entity.Password = request.Password;
            entity.FirstName = request.FirstName;
            entity.LastName = request.LastName;
            entity.Address = request.Address;
            entity.Description = request.Description;
            entity.Role = request.Role;
            entity.CreateDate = DateTime.Now;

            this._userDomainRepository.CreateUser(entity);

            response.Email = entity.Email;
            response.FirstName = entity.FirstName;
            response.Role = entity.Role;


            return response;
        }

        public bool DeleteUserById(int userId)
        {
            var user = this._userDomainRepository.GetUserById(userId);
            if (user == null)
            {
                return false;
            }
            this._userDomainRepository.DeleteUserById(userId);
            return true;
        }

        public EditUserInfoResponse EditUserInfo(EditUserInfoRequest request)
        {
            EditUserInfoResponse infoResponse = new EditUserInfoResponse();
            var user = this._userDomainRepository.GetUserByEmail(request.Email);
            if (user == null)
            {
                throw new Exception("User not found!");
            }
            user.FirstName = request.FirstName;
            user.LastName = request.LastName;
            user.Address = request.Address;
            user.Description = request.Description;
            user.UpdateDate = DateTime.Now;
            this._userDomainRepository.Update(user);

            infoResponse.FirstName = request.FirstName;
            infoResponse.LastName = request.LastName;
            infoResponse.Address = request.Address;
            infoResponse.Description = request.Description;


            return infoResponse;
        }

        public GetUserResponse GetUserByEmail(string email)
        {
            GetUserResponse response = new GetUserResponse();
            var user = this._userDomainRepository.GetUserByEmail(email);
            if (user == null)
            {
                throw new Exception("User not found!");
            }
            response.Id = user.Id;
            response.FirstName = user.FirstName;
            response.LastName = user.LastName;
            response.Address = user.Address;
            response.Description = user.Description;
            response.Email = user.Email;
            response.Role = response.Role;

            return response;
        }

        public GetUserResponse GetUserById(int userId)
        {
            GetUserResponse response = new GetUserResponse();
            var user = this._userDomainRepository.GetUserById(userId);
            if (user == null)
            {
                throw new Exception("User not found!");
            }
            response.Id = user.Id;
            response.FirstName = user.FirstName;
            response.LastName = user.LastName;
            response.Address = user.Address;
            response.Description = user.Description;
            response.Email = user.Email;
            response.Role = response.Role;

            return response;
        }
        public bool ValidateUser(c request){
            
            bool isValidUser = false;
            var user = this._userDomainRepository.GetUserByEmail(request.Email);
            if (user == null)
            {
                isValidUser = false;
                return isValidUser;
            }
            if (user.Password == request.Password) { 
                isValidUser = true;
            }
            return isValidUser;
        }
    }
}

