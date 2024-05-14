namespace Project.COREMVC.Areas.Admin.Models.Movies.RequestModels
{
    public class CreateMovieRequestModel
    {
        public string MovieName { get; set; }
        public string? Description { get; set; }
        public string? ImagePath { get; set; }
        public string? VideoPath { get; set; }
    }
}
