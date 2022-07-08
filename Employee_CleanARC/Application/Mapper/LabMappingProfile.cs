using a.Core.Entities;
using Application.Queries;
using AutoMapper;
using b.Application.Command.Emloyee_command;
using b.Application.Responses;

namespace Application.Mapper
{
    public class LabMappingProfile : Profile
    {
        public LabMappingProfile()
        {
            // auto gán giá trị chỉ cần khai báo đối tượng cần map
            CreateMap<Lab, LabResponses>().ReverseMap();
            CreateMap<Lab, AddLabCommand>().ReverseMap();
            CreateMap<Lab, UpdateLabCommand>().ReverseMap();
            CreateMap<Lab, GetOneLabQuery>().ReverseMap();
            CreateMap<Lab, DeleteLabCommand>().ReverseMap();

        }
    }
}
