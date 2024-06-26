using Project.COREMVC.Models.Members.Movies;

using Project.COREMVC.Models.Members.Casts;


namespace Project.COREMVC.Models.Members.MovieDetailsVM
{
    public class MovieDetailsVM
    {
        public  MovieVM Movie { get; set; }      
        public  List<CastVM> Casts { get; set; }                
    }
}
