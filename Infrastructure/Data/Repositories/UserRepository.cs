using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Data.Context;
using Infrastructure.Data.Repositories.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Repositories
{
    public class UserRepository : GenericDataDbRepository<UserEntity>, IUserDomainRepository
    {
        public UserRepository(AppDbContext contex) : base(contex)
        {
            Context = contex;
        }
        public int CreateUser(UserEntity entity)
        {
            this.AddSync(entity);
            return entity.Id;
        }

        public void DeleteUserById(int id)
        {
            UserEntity userEntity = this.GetUserById(id);
            this.RemoveSync(userEntity);
        }

        public UserEntity GetUserByEmail(string email)
        {
            UserEntity entity = this.Context.UserEntity.Where(x => x.Email == email).FirstOrDefault();
            return entity;
        }

        public UserEntity GetUserById(int id)
        {
            UserEntity entity = this.Context.UserEntity.Where(x => x.Id == id).FirstOrDefault();
            return entity;
        }

        
    }
}
