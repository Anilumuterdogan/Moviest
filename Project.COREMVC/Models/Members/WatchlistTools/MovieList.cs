using Newtonsoft.Json;

namespace Project.COREMVC.Models.Members.WatchlistTools
{
    [Serializable]
    public class MovieList
    {
        [JsonProperty("_myMovie")]
        Dictionary<int, MovieItem> _myMovie;

        public MovieList() 
        {
            _myMovie = new Dictionary<int, MovieItem>();
        }

        [JsonProperty("GetMovieItems")]
        public List<MovieItem> GetMovieItems
        {
            get
            {
                return _myMovie.Values.ToList();
            }
        }

        public void AddToMovie(MovieItem mi)
        {
            if (!_myMovie.ContainsKey(mi.ID))
            {
                _myMovie.Add(mi.ID, mi);
            }
            
        }

        public void RemoveMovieList(int id) 
        {
            _myMovie.Remove(id);
        }

        [JsonProperty("MovieTotal")]
        public decimal MovieTotal
        {
            get
            {
                return _myMovie.Count;
            }

        }
        
    }
}
