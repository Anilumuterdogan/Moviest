using Project.COREMVC.Areas.Admin.Models.Casts.PureVms;
using Project.COREMVC.Areas.Admin.Models.Genres.PureVms;
using Project.COREMVC.Areas.Admin.Models.Movies.PureVms;

namespace Project.COREMVC.Areas.Admin.Models.Movies.SharedVMs
{
    public class SharedVM
    {
        public MovieVM Movie { get; set; }
        public GenreVM Genre { get; set; }
        public CastVM Cast { get; set; }
    }
}
