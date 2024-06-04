namespace Project.COREMVC.Models.Members.WatchlistTools
{
    public class MovieList
    {
        Dictionary<int, MovieItem> _myMovie;

        public MovieList() 
        {
            _myMovie = new Dictionary<int, MovieItem>();
        }

        public List<MovieItem> GetMovieItems() 
        {
            return _myMovie.Values.ToList();
        }

        public void RemoveMovieList(int id) 
        {
            _myMovie.Remove(id);
        }

        public decimal MovieTotal()
        {
            return _myMovie.Count;
        }
    }
}
