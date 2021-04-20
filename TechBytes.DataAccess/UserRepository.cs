using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechBytes.ApplicationLogic.Abstractions;
using TechBytes.ApplicationLogic.Models;

namespace TechBytes.DataAccess
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(TechBytesDBContext dbContext) : base(dbContext)
        {
        }

        public User GetUserById(Guid id)
        {
            return dbContext.Users
                .Where(user => user.ID == id)
                .SingleOrDefault();
        }
    }
}
