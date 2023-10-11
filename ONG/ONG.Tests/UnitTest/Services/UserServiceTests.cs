using Domain.Entities;
using Domain.Interfaces.Repositories;
using Moq;
using ONG.Services.Services;
using ONG.Tests.Helpers.Fixture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONG.Tests.UnitTest.Services
{
    public class UserServiceTests
    {
        private readonly Mock<IUserRepository> _mockUserRepository;

        public UserServiceTests()
        {
            _mockUserRepository = new Mock<IUserRepository>();
        }


        [Fact]
        public async Task Create_UserValid_ReturnTrue()
        {
            //Arrange
            var model = UserModelFixture.GetUserModel();
            _mockUserRepository.Setup(x => x.Add(It.IsAny<User>())).Returns(new User());
            var service = new UserService(_mockUserRepository.Object);

            //Act
            var result = await service.Add(model);

            //Assert
            Assert.True(result);
        }
    }
}
