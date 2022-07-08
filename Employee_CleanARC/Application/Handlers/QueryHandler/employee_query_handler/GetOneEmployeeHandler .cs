namespace Application.Handlers.QueryHandlers
{
    public class GetOneEmployeeHandler { }/* : IRequestHandler<GetOneEmployeeQuery, List<Employee>>
    {
        private readonly IEmployeeRepository _employeeRepo;


        public GetOneEmployeeHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepo = employeeRepository;
        }
        public async Task<List<Employee>> Handle(GetOneEmployeeQuery request, CancellationToken cancellationToken)
        {
            return (List<Employee>)await _employeeRepo.GetByIdAsync();
        }
    }*/
}
