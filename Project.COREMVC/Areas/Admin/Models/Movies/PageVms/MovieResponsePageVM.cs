using Project.COREMVC.Areas.Admin.Models.Movies.ResponseModels;

namespace Project.COREMVC.Areas.Admin.Models.Movies.PageVms
{
    public class MovieResponsePageVM
    {
        public List<MovieResponseModel> Movies { get; set; }

        public MovieResponseModel Movie { get; set; }
    }
}
