using MediatR;


namespace Application.Queries
{
    public class GetOneEmployeeQuery : IRequest<List<a.Core.Entities.Employee>>
    {
        public int Id { get; set; }
    }
}
