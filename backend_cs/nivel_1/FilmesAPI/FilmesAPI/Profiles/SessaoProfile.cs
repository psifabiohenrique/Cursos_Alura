using AutoMapper;
using FilmesAPI.Data.Dtos;
using FilmesAPI.Models;

public class SessaoProfile : Profile
{
    public SessaoProfile()
    {
        CreateMap<CreateSessaoDto, Sessao>();
        CreateMap<Sessao, ReadSessaoDto>();
        CreateMap<UpdateSessaoDto, Sessao>();
    }
}
