using Bogus;
using Domain.Model;
using ONG.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONG.Tests.Helpers.Fixture
{
    public class OrganizationModelFixture
    {
        public static OrganizationModel GetOrganizationModel()
        {
            var model = new Faker<OrganizationModel>();
            model.RuleFor(x => x.CNPJ, r => "1826417095122");
            model.RuleFor(x => x.Acting, r => "Cultura");
            model.RuleFor(x => x.Name, r => "Nome da ONG");
            return model;
        }
    }
}
