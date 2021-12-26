using CopiaFacebook.Application.Queries.GetAllPosts;
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
    public class GetAllPostsQueryHandlerTest
    {
        [Fact]
        public async Task ThreePostExist_Executed_ReturnThreePostViewModel()
        {
            //Arrange
            var posts = new List<Post>
            {
                new Post("Teste1",1),
                new Post("Teste2",1),
                new Post("Teste3",1),
            };

            var postRepositoryMock = new Mock<IPostRepository>();
            postRepositoryMock.Setup(pr => pr.GetAll().Result).Returns(posts);

            var getAllPostsQuery = new GetAllPostsQuery("");
            var getAllPostsQueryHandler = new GetAllPostsQueryHandler(postRepositoryMock.Object);

            //Act
            var postViewModelList = await getAllPostsQueryHandler.Handle(getAllPostsQuery, new CancellationToken());

            //Assert
            Assert.NotNull(postViewModelList);
            Assert.NotEmpty(postViewModelList);
            Assert.Equal(posts.Count, postViewModelList.Count);
            postRepositoryMock.Verify(pr => pr.GetAll().Result, Times.Once);
        }
    }
}