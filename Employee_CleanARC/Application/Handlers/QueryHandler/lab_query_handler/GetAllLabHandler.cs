using a.Core.Entities;
using a.Core.Repository;
using Application.Queries;
using MediatR;

namespace b.Application.Handlers.QueryHandlers
{
    public class GetAllLabHandler : IRequestHandler<GetAllLabQuery, List<Lab>>
    {
        private readonly ILabRepository _employeeRepo;

        public GetAllLabHandler(ILabRepository employeeRepository)
        {
            _employeeRepo = employeeRepository;
        }
        public async Task<List<Lab>> Handle(GetAllLabQuery request, CancellationToken cancellationToken)
        {
            return (List<Lab>)await _employeeRepo.GetAllAsync();
        }
    }
}
