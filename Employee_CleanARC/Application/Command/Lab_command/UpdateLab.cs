
using b.Application.Responses;
using MediatR;

namespace b.Application.Command.Emloyee_command
{
    public class UpdateLabCommand : IRequest<LabResponses>
    {
        public int? Id { get; set; }
        public string? labName { get; set; }
        public string? Location { get; set; }
    }
}
