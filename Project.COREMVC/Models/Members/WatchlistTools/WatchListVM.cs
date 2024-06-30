using Project.COREMVC.Models.Members.Movies;

namespace Project.COREMVC.Models.Members.WatchlistTools
{
    public class WatchListVM
    {
        public int AppUserID { get; set; }
        public int MovieID { get; set; }

        public List<MovieVM> Movies { get; set; }
    }
}
