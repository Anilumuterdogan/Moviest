using Project.COREMVC.Models.Members.Genres;
using Project.COREMVC.Models.Members.Movies;
using X.PagedList;

namespace Project.COREMVC.Models.Members.MemberPageVM
{
    public class MemberMovieVM
    {
        public IPagedList<MovieVM> Movies { get; set; }
        public List<GenreVM> Genres { get; set; }
    }
}
