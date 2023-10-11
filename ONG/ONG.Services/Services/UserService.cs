﻿using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Model;
using ONG.Domain.Interfaces.Services;
using ONG.Domain.Seedwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONG.Services.Services
{
    public class UserService : BaseService<User, UserModel>, IUserService
    {

        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public async Task<bool> Add(UserModel model)
        {
            var existingUser = await _repository.GetByEmail(model.Email);
            if(existingUser != null) 
                AddNotification($"Usuário com o e-mail {model.Email} já está cadastrado no sistema");
            
            var domain = Map(model);

            _repository.Add(domain);

            return true;
        }
    }
}
