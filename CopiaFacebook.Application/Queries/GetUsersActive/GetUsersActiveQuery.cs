using CopiaFacebook.Application.ViewModels;
using CopiaFacebook.Core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopiaFacebook.Application.Queries.GetUsersActive
{
    public class GetUsersActiveQuery : IRequest<List<UserViewModel>>
    {
        public string Query { get; private set; }

        public GetUsersActiveQuery(string query)
        {
            Query = query;
        }
    }
}
