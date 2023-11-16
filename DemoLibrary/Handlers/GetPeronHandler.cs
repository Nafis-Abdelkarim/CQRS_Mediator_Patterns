using DemoLibrary.DataAccess;
using DemoLibrary.Models;
using DemoLibrary.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Handlers
{
    internal class GetPeronHandler : IRequestHandler<GetPersonQuery, PersonModel>
    {
        private readonly IDataAccess _data;

        public GetPeronHandler(IDataAccess data)
        {
            _data = data;
        }

        public Task<PersonModel> Handle(GetPersonQuery request, CancellationToken cancellationToken) 
        {
            return Task.FromResult(_data.GetPerson(1));
        }
    }
}
