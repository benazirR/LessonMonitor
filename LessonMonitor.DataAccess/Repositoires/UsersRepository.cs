using LessonMonitor.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace LessonMonitor.DataAccess.Repositoires
{
    public class UsersRepository : IUsersRepository
    {
        private List<Core.User> _users;
        public UsersRepository()
        {
            _users = new List<Core.User>();
        }

        public void Create(Core.User user)
        {
            _users.Add(user);
        }

        public IEnumerable<Core.User> GetAll()
        {
            return _users;
        }
    }
}
