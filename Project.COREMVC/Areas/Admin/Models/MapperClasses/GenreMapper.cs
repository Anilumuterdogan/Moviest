using Project.COREMVC.Areas.Admin.Models.Genres.PureVms;
using Project.ENTITIES.Models;

namespace Project.COREMVC.Areas.Admin.Models.MapperClasses
{
    public static class GenreMapper
    {
        public static GenreVM GetGenreVM(Genre genre)
        {
            return new()
            {
                ID = genre.ID,
                GenreName = genre.GenreName
            };
        }
    }
}
