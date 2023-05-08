namespace CRUD_Api.Profile
{
    using AutoMapper;
    using CRUD_Api.Data.Dto;
    using CRUD_Api.Models;

    public class FilmeProfile : Profile
    {
        public FilmeProfile()
        {
            CreateMap<CreateFilmeDto, Filme>();
            CreateMap<Filme, ReadFilmeDto>();
            CreateMap<UpdateFilmeDto, Filme>();
        }
    }
}
