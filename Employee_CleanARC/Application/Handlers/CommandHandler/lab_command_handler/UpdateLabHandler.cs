//giao tiếp giữ các phần khác nhau của ứng dụng 

namespace b.Application.Handlers.CommandHandlers
{

    public class UpdateLabHandler { }/* : IRequestHandler<UpdateEmployeeCommand, EmployeeResponse>
    {
        private readonly IEmployeeRepository _employeeRepo;
        public UpdateLabHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepo = employeeRepository;
        }
        public async Task<EmployeeResponse> Handle(UpdateEmployeeCommand request, CancellationToken cancellationToken)
        {

            Core.Entities.Employee employee = EmployeeMapper.Mapper.Map<Core.Entities.Employee>(request);


            if (employee is null)
            {
                throw new ApplicationException("map xảy ra lỗi");
            }

            Core.Entities.Employee oldEmployee = await _employeeRepo.UpdateAsync();



            EmployeeResponse employeeResponse = EmployeeMapper.Mapper.Map<EmployeeResponse>(oldEmployee);
            return employeeResponse;
        }
    } /* */
}
