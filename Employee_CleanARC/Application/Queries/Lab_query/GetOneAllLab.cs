using MediatR;


namespace Application.Queries
{
    public class GetOneLabQuery : IRequest<List<a.Core.Entities.Lab>>
    {
        public int Id { get; set; }
    }
}
