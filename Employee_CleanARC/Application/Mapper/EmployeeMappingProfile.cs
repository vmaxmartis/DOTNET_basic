using a.Core.Entities;
using Application.Queries;
using AutoMapper;
using b.Application.Command.Emloyee_command;
using b.Application.Responses;

namespace Application.Mapper
{
    public class EmployeeMappingProfile : Profile
    {
        public EmployeeMappingProfile()
        {
            // auto gán giá trị chỉ cần khai báo đối tượng cần map
            CreateMap<Employee, EmployeeResponses>().ReverseMap();
            CreateMap<Employee, AddEmployeeCommand>().ReverseMap();
            CreateMap<Employee, UpdateEmployeeCommand>().ReverseMap();
            CreateMap<Employee, GetOneEmployeeQuery>().ReverseMap();
            CreateMap<Employee, DeleteEmployeeCommand>().ReverseMap();

        }
    }
}
