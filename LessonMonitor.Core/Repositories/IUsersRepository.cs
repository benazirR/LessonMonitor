using System.Collections.Generic;

namespace LessonMonitor.Core.Repositories
{
    public interface IUsersRepository
    {
        void Create(User user);
        IEnumerable<User> GetAll();
    }
}
