
using b.Application.Responses;
using MediatR;

namespace b.Application.Command.Emloyee_command
{
    public class AddLabCommand : IRequest<LabResponses>
    {
        public string? labName { get; set; }
        public string? Location { get; set; }
    }
}
