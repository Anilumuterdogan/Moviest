using Project.ENTITIES.Models;

namespace Project.COREMVC.Areas.Admin.Models.MovieCasts.ResponseModels
{
    public class MovieCastSharedPageVM
    {
        public int CastID { get; set; }
        public int MovieID { get; set; }
        public List<Cast> Casts { get; set; }
    }
}
