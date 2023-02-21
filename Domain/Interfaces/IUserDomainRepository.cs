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
        int CreateUser(UserEntity entity);
        UserEntity GetUserByEmail(string email);
        UserEntity GetUserById(int id);
        void DeleteUserById(int id);


    }
}
