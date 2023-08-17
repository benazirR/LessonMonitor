using System.Collections.Generic;

namespace LessonMonitor.Core.Services
{
    public interface IUsersService
    {
        void Create(User user);
        IEnumerable<User> GetAll();
    }
}
