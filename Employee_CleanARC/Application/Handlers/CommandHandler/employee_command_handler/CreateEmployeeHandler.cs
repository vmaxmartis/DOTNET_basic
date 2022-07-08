//giao tiếp giữ các phần khác nhau của ứng dụng 

namespace Application.Handlers.CommandHandlers
{
    public class CreateEmployeeHandler { }
    /*
    public class CreateEmployeeHandler : IRequestHandler<AddEmployeeCommand, EmployeeResponses>
    {
        private readonly IEmployeeRepository _employeeRepo;

        // hàm xử lý tạo nhân viên nhận vào Repo từ core
        public CreateEmployeeHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepo = employeeRepository;
        }
        public async Task<EmployeeResponses> Handle(AddEmployeeCommand request, CancellationToken cancellationToken)
        {
            Employee employee = EmployeeMapper.Mapper.Map<Employee>(request);
            if (employee is null)
            {
                throw new ApplicationException("map xảy ra lỗi");
            }
            Employee newEmployee = await _employeeRepo.AddAsync(employee);
          
            EmployeeResponses employeeResponse = EmployeeMapper.Mapper.Map<EmployeeResponses>(newEmployee);
            return employeeResponse;
        }
    }*/
}
