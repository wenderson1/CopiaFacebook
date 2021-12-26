using CopiaFacebook.Application.Queries.GetAllUsers;
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

namespace CopiaFacebool.UnitTests.Applications.Queries
{
    public class GetAllUsersQueryHandlerTests
    {
        [Fact]
        public async Task ThreeUsersExist_Executed_ReturnThreeUserViewModel()
        {
            //Arrange
            var users = new List<User>
            {
                new User ("Wenderson1"),
                new User ("Wenderson2"),
                new User ("Wenderson3")
            };

            var userRepositoryMock = new Mock<IUserRepository>();
            userRepositoryMock.Setup(pr => pr.GetAll().Result).Returns(users);

            var getAllUsersQuery = new GetAllUsersQuery("");
            var getAllUsersQueryHandler = new GetAllUsersQueryHandler(userRepositoryMock.Object);

            //Act
            var userViewModelList = await getAllUsersQueryHandler.Handle(getAllUsersQuery, new CancellationToken());

            //Assert
            Assert.NotNull(userViewModelList);
            Assert.NotEmpty(userViewModelList);
            Assert.Equal(users.Count, userViewModelList.Count);
            userRepositoryMock.Verify(pr => pr.GetAll().Result, Times.Once);
        }
    }
}
