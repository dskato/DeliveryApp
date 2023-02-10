using Domain.Entities;
using Domain.Interfaces.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IUserDomainRepository : IGenericDataRepository<UserEntity>
    {
        bool CreateUser(UserEntity entity);
        UserEntity GetUserByEmail(string email);
        UserEntity GetUserById(int id);
        bool UpdateUserBasicInfo(UserEntity entity);
        bool DeleteUserById(int id);

    }
}
