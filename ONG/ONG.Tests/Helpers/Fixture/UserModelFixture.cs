using Bogus;
using Domain.Entities;
using Domain.Model;
using ONG.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ONG.Tests.Helpers.Fixture
{
    public class UserModelFixture
    {
        public static UserModel GetUserModel()
        {
            var model = new Faker<UserModel>();
            model.RuleFor(x => x.Name, r => r.Random.String(10));
            model.RuleFor(x => x.CPF, r => "18264170951");
            model.RuleFor(x => x.Email, r => "");
            model.RuleFor(x => x.Age, r => r.Random.Int(18, 75));
            model.RuleFor(x => x.Uf, r => r.Random.String(2));
            model.RuleFor(x => x.City, r => r.Random.String(10));
            model.RuleFor(x => x.Gender, r => r.Random.String(1));
            return model;
        }

        public static List<UserDTO> GetUserDTOs()
        {
            var dto = new Faker<UserDTO>();
            dto.RuleFor(x => x.Name, r => r.Random.String(10));
            return dto.Generate(5);
        }

        public static User GetUserDomain()
        {
            var domain = new Faker<User>();
            domain.RuleFor(x => x.Name, r => r.Random.String(10));
            domain.RuleFor(x => x.CPF, r => "18264170951");
            domain.RuleFor(x => x.Email, r => "fribeiro@gmail.com");
            domain.RuleFor(x => x.Age, r => r.Random.Int(18, 75));
            domain.RuleFor(x => x.Uf, r => r.Random.String(2));
            domain.RuleFor(x => x.City, r => r.Random.String(10));
            domain.RuleFor(x => x.Gender, r => r.Random.String(1));
            domain.RuleFor(x => x.Password, r => "12345");
            return domain;
        }
    }
}
