namespace Project.COREMVC.Areas.Admin.Models.Movies.PureVms
{
    public class MovieVM
    {
        public int ID { get; set; }
        public string MovieName { get; set; }
        public string? Description { get; set; }
        public string? ImagePath { get; set; }
        public string? VideoPath { get; set; }
    }
}
