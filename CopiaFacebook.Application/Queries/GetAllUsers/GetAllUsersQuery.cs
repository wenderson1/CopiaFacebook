using CopiaFacebook.Application.ViewModels;
using CopiaFacebook.Core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopiaFacebook.Application.Queries.GetAllUsers
{
    public class GetAllUsersQuery : IRequest<List<UserViewModel>>
    {
        public string Query { get; private set; }

        public GetAllUsersQuery(string query)
        {
            Query = query;
        }
    }
}
