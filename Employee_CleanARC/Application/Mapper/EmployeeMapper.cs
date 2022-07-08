using AutoMapper;
using System;

namespace Application.Mapper
{
    public class EmployeeMapper
    {
        //Map từ DB >> tự động map các props  
        private static readonly Lazy<IMapper> Lazy = new(() =>
        {
            MapperConfiguration config = new(cfg =>
            {
                cfg.ShouldMapProperty = p => p.GetMethod.IsPublic || p.GetMethod.IsAssembly;
                cfg.AddProfile<EmployeeMappingProfile>();
            });
            IMapper mapper = config.CreateMapper();
            return mapper;
        });

        public static IMapper Mapper => Lazy.Value;
    }
}
