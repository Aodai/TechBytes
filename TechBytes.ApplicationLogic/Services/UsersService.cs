using System;
using System.Collections.Generic;
using TechBytes.ApplicationLogic.Abstractions;
using TechBytes.ApplicationLogic.Exceptions;
using TechBytes.ApplicationLogic.Models;

namespace TechBytes.ApplicationLogic.Services
{
    public class UsersService
    {
        private IUserRepository userRepository;

        public UsersService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public User GetUserById(string id)
        {
            Guid userGuid = Guid.Empty;
            if(!Guid.TryParse(id, out userGuid))
                throw new Exception("Invalid Guid format");
            var user = userRepository.GetUserById(userGuid) ?? throw new EntityNotFoundException(userGuid);
            return user;
        }

        public IEnumerable<User> GetAll()
        {
            var users = userRepository.GetAll() ?? throw new EntityNotFoundException("No entities found");
            return users;
        }

        public User Add(User user)
        {
            return userRepository.Add(user);
        }

        public User Update(User user)
        {
            return userRepository.Update(user);
        }

        public bool Delete(User user)
        {
            return userRepository.Delete(user);
        }
    }
}
