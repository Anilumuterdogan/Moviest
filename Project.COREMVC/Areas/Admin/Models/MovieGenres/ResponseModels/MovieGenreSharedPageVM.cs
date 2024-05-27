using NuGet.Protocol.Core.Types;
using Project.COREMVC.Areas.Admin.Models.Genres.PureVms;
using Project.COREMVC.Areas.Admin.Models.Movies.PureVms;
using Project.ENTITIES.Models;

namespace Project.COREMVC.Areas.Admin.Models.MovieGenres.ResponseModels
{
    public class MovieGenreSharedPageVM
    {
        public int GenreID { get; set; }
        public int MovieID { get; set; }
        public List<Genre> Genres { get; set; }
    }
}
