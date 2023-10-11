using Bogus;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
