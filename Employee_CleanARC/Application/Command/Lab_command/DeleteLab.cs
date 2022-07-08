using b.Application.Responses;
using MediatR;

namespace b.Application.Command.Emloyee_command
{
    public class DeleteLabCommand : IRequest<LabResponses>
    {
        public int Id { get; set; }
    }
}
