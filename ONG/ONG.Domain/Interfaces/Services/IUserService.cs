using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONG.Domain.Interfaces.Services
{
    public interface IUserService
    {
        Task<bool> Add(UserModel model);
    }
}
