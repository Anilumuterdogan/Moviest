using Project.COREMVC.Areas.Admin.Models.Movies.RequestModels;

namespace Project.COREMVC.Areas.Admin.Models.Movies.PageVms
{
    public class MovieRequestPageVM
    {
        public CreateMovieRequestModel Movie { get; set; }

        public int[] SelectedCasts { get; set; }
        public int[] SelectedGenres { get; set; }
    }
}
