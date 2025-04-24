using AgileTest.Data.Entities;
using AutoMapper;

namespace AgileTest.Common.Models
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Reset();

            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<StudentModel, StudentEntity>();                
            });
        } 
    }
}
