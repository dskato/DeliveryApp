using API.DTOs.Users;

namespace API
{
    public partial interface IApplicationService
    {
        CreateUserResponse CreateUser(CreateUserRequest request);
        bool DeleteUserById(int userId);
        GetUserResponse GetUserByEmail(string email);
        GetUserResponse GetUserById(int userId);
        EditUserInfoResponse EditUserInfo(EditUserInfoRequest request);

    }
}

