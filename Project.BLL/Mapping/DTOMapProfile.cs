using AutoMapper;
using Project.BLL.DTOClasses;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.Mapping
{
    public class DTOMapProfile : Profile
    {
        public DTOMapProfile()
        {
            #region AppUserDTOMapping
            CreateMap<AppUser, AppUserDTO>()
                .ForMember(dest => dest.UserName, act => act.MapFrom(src => src.UserName))
                .ForMember(dest => dest.UserPassword, act => act.MapFrom(src => src.PasswordHash))
                .ForMember(dest => dest.AppUserProfile, act => act.MapFrom(src => src.Profile))
                .ReverseMap();
            #endregion

            #region AppUserProfileDTOMapping
            CreateMap<AppUserProfile, AppUserProfileDTO>()
                .ForMember(dest => dest.FirstName, act => act.MapFrom(src => src.FirstName))
                .ForMember(dest => dest.LastName, act => act.MapFrom(src => src.LastName))
                .ForMember(dest => dest.AppUser, act => act.MapFrom(src => src.AppUser))
                .ReverseMap();
            #endregion

            #region CastDTOMapping
            CreateMap<Cast, CastDTO>()
                .ForMember(dest => dest.FirstName, act => act.MapFrom(src => src.FirstName))
                .ForMember(dest => dest.LastName, act => act.MapFrom(src => src.LastName))
                .ForMember(dest => dest.Description, act => act.MapFrom(src => src.Description))
                .ForMember(dest => dest.ImagePath, act => act.MapFrom(src => src.ImagePath))
                .ForMember(dest => dest.VideoPath, act => act.MapFrom(src => src.VideoPath))
                .ForMember(dest => dest.MovieCasts, act => act.MapFrom(src => src.MovieCasts))
                .ReverseMap();
            #endregion

            #region GenreDTOMapping
            CreateMap<Genre, GenreDTO>()
                .ForMember(dest => dest.GenreName, act => act.MapFrom(src => src.GenreName))
                .ForMember(dest => dest.MovieGenres, act => act.MapFrom(src => src.MovieGenres))
                .ReverseMap();
            #endregion

            #region MovieCastDTOMapping
            CreateMap<MovieCast, MovieCastDTO>()
                .ForMember(dest => dest.MovieID, act => act.MapFrom(src => src.MovieID))
                .ForMember(dest => dest.CastID, act => act.MapFrom(src => src.CastID))
                .ForMember(dest => dest.Movie, act => act.MapFrom(src => src.Movie))
                .ForMember(dest => dest.Cast, act => act.MapFrom(src => src.Cast))
                .ForMember(dest => dest.NameInMovie, act => act.MapFrom(src => src.NameInMovie))
                .ReverseMap();
            #endregion

            #region MovieDTOMapping
            CreateMap<Movie, MovieDTO>()
                .ForMember(dest => dest.MovieName, act => act.MapFrom(src => src.MovieName))
                .ForMember(dest => dest.Description, act => act.MapFrom(src => src.Description))
                .ForMember(dest => dest.ImagePath, act => act.MapFrom(src => src.ImagePath))
                .ForMember(dest => dest.VideoPath, act => act.MapFrom(src => src.VideoPath))
                .ForMember(dest => dest.MovieCasts, act => act.MapFrom(src => src.MovieCasts))
                .ForMember(dest => dest.MovieGenres, act => act.MapFrom(src => src.MovieGenres))
                .ReverseMap();
            #endregion

            #region MovieGenreDTOMapping
            CreateMap<MovieGenre, MovieGenreDTO>()
                .ForMember(dest => dest.MovieID, act => act.MapFrom(src => src.MovieID))
                .ForMember(dest => dest.GenreID, act => act.MapFrom(src => src.GenreID))
                .ForMember(dest => dest.Movie, act => act.MapFrom(src => src.Movie))
                .ForMember(dest => dest.Genre, act => act.MapFrom(src => src.Genre))
                .ReverseMap();
            #endregion
        }
    }
}
