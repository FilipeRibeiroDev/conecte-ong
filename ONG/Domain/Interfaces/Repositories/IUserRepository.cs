using Domain.Entities;
using Domain.Seedwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        User Add(User user);
        Task<User?> GetAsync(int userId);
        Task<User?> GetByEmail(string email);
        void Update(User user);
    }
}
