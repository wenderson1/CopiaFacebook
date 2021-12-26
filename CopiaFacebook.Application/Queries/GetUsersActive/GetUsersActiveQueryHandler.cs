using CopiaFacebook.Core.Entities;
using CopiaFacebook.Core.Repositories;
using CopiaFacebook.Infrastructure.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CopiaFacebook.Application.Queries.GetUsersActive
{
    public class GetUsersActiveQueryHandler : IRequestHandler<GetUsersActiveQuery, List<User>>
    {

        private readonly IUserRepository _userRepository;

        public GetUsersActiveQueryHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<List<User>> Handle(GetUsersActiveQuery request, CancellationToken cancellationToken)
        {
            return await _userRepository.GetUsersActive();
        }
    }
}
