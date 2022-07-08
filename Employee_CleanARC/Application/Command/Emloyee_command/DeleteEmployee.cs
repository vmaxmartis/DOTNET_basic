using b.Application.Responses;
using MediatR;

namespace b.Application.Command.Emloyee_command
{
    public class DeleteEmployeeCommand : IRequest<EmployeeResponses>
    {
        public int Id { get; set; }
    }
}
