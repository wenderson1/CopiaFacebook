using CopiaFacebook.Application.Commands.CreateUser;
using CopiaFacebook.Core.Entities;
using CopiaFacebook.Core.Repositories;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace CopiaFacebool.UnitTests.Applications.Commands
{
   public class CreateUserCommandHandlerTests
    {
        [Fact]
        public async Task InputDataIsOk_Executed_ReturnProjectId()
        {
            //Arrange
            var userRepository = new Mock<IUserRepository>();

            var createUserCommand = new CreateUserCommand("Wenderson");
            var createUserCommandHandler = new CreateUserCommandHandler(userRepository.Object);

            //Act
            var id = await createUserCommandHandler.Handle(createUserCommand, new CancellationToken());

            //Assert
            Assert.True(id >= 0);

            userRepository.Verify(pr => pr.Create(It.IsAny<User>()), Times.Once);

        }
    }
}
