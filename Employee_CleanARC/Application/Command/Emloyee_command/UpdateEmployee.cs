using b.Application.Responses;
using MediatR;

namespace b.Application.Command.Emloyee_command
{
    public class UpdateEmployeeCommand : IRequest<EmployeeResponses>
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Lab { get; set; }


    }
}

