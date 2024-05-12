namespace Project.COREMVC.Areas.Admin.Models.Casts.RequestModels
{
    public class CreateCastRequestModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Description { get; set; }
        public string? ImagePath { get; set; }
        public string? VideoPath { get; set; }
    }
}
