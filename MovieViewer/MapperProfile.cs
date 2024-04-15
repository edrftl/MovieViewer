using AutoMapper;
using MovieViewer.Data.Entities;
using MovieViewer.Models;

namespace MovieViewer
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<FilmModel, Film>().ReverseMap();
            CreateMap<Film, FilmCardModel>();
        }
    }
}
