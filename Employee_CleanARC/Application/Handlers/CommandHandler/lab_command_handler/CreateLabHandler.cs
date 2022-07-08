namespace b.Application.Handlers.CommandHandlers
{

    public class CreateLabHandler { }/* : IRequestHandler<AddlabCommand, LabResponse>
    {
        private readonly ILabRepository _LabRepo;

       
        public CreateLabHandler(ILabRepository LabRepository)
        {
            _LabRepo = LabRepository;
        }
        public async Task<LabResponses> Handle(AddlabCommand request, CancellationToken cancellationToken)
        {
          
           Lab Lab = LabMapper.Mapper.Map<Lab>(request);

         
            if (Lab is null)
            {
                throw new ApplicationException("map xảy ra lỗi");
            }
           
            Lab newLab = await _LabRepo.AddAsync(Lab);
            LabResponses LabResponse = LabMapper.Mapper.Map<LabResponses>(newLab);
            return LabResponse;
        }
    }*/
}
