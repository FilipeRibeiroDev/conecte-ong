using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Seedwork;
using Microsoft.EntityFrameworkCore;
using ONG.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONG.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly OngContext _context;

        public IUnitOfWork UnitOfWork => _context;

        public UserRepository(OngContext context)
        {
            _context = context;
        }
        public User Add(User user)
        {
            return _context.User.Add(user).Entity;
        }

        public async Task<User?> GetAsync(int userId)
        {
            return await _context.User.FirstOrDefaultAsync(o => o.Id == userId);
        }

        public async Task<User?> GetByEmail(string email)
        {
            return await _context.User.FirstOrDefaultAsync(x => x.Email == email);
        }

        public void Update(User user)
        {
            _context.Entry(user).State = EntityState.Modified;
        }

        public async Task<List<UserDTO>> ListAsync()
        {
            var users = await _context.User.Select( p => new UserDTO()
            {
                Age = p.Age,
                Name = p.Name,
                Profession = p.Profession,
            }).ToListAsync();

            return users;
        }
    }
}
