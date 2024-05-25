using Project.COREMVC.Areas.Admin.Models.MovieGenres.ResponseModels;
using Project.ENTITIES.Models;

namespace Project.COREMVC.Areas.Admin.Models.MovieGenres
{
    public class MovieGenreMix
    {
        public List<Genre> Genres { get; set; }
        public MovieGenreResponseModel MovieGenreResponse { get; set; }
    }
}
