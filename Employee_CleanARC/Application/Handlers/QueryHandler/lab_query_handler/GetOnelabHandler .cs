using Application.Queries;
using Core.Entities;
using Core.Repositories;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Handlers.QueryHandlers
{
    public class GetOneEmployeeHandler : IRequestHandler<GetOneEmployeeQuery, List<Core.Entities.Employee>>
    {
        private readonly IEmployeeRepository _employeeRepo;


        public GetOneEmployeeHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepo = employeeRepository;
        }
        public async Task<List<Core.Entities.Employee>> Handle(GetOneEmployeeQuery request, CancellationToken cancellationToken)
        {
            return (List<Employee>)await _employeeRepo.GetByIdAsync();
        }
    }
}
