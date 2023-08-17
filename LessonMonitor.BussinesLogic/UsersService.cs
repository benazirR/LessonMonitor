using LessonMonitor.Core;
using LessonMonitor.Core.Repositories;
using LessonMonitor.Core.Services;
using System;
using System.Collections.Generic;

namespace LessonMonitor.BussinesLogic
{
    public class UsersService : IUsersService
    {
        private IUsersRepository _usersRepository;
        public UsersService(IUsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }

        public void Create(User user)
        {
            _usersRepository.Create(user);
        }

        public IEnumerable<User> GetAll()
        {
            var users = _usersRepository.GetAll();
            return users;
        }
    }
}
