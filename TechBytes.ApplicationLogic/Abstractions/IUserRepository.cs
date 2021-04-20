using System;
using TechBytes.ApplicationLogic.Models;

namespace TechBytes.ApplicationLogic.Abstractions
{
    public interface IUserRepository : IRepository<User>
    {
        User GetUserById(Guid id);
    }
}
