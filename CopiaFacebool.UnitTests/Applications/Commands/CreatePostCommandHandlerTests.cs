using CopiaFacebook.Application.Commands.CreatePost;
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
   public class CreatePostCommandHandlerTests
    {
        [Fact]
        public async Task InputDataIsOk_Executed_ReturnProjectId()
        {
            //Arrange
            var postRepository = new Mock<IPostRepository>();

            var createPostCommand = new CreatePostCommand("Descrição LEgal", 1);
            var createPostCommandHandler = new CreatePostCommandHandler(postRepository.Object);

            //Act
            var id = await createPostCommandHandler.Handle(createPostCommand, new CancellationToken());

            //Assert
            Assert.True(id >= 0);

            postRepository.Verify(pr => pr.Create(It.IsAny<Post>()), Times.Once);

        }
    }
}
