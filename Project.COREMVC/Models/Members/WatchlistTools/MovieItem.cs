using Newtonsoft.Json;

namespace Project.COREMVC.Models.Members.WatchlistTools
{
    [Serializable]
    public class MovieItem
    {
        [JsonProperty("ID")]
        public int ID { get; set; }

        [JsonProperty("MovieName")]
        public string MovieName { get; set; }

        [JsonProperty("ImagePath")]
        public string ImagePath { get; set; }

        
    }
}
