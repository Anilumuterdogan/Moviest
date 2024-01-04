using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DTOClasses
{
    public class GenreDTO : BaseDTO
    {
        public string GenreName { get; set; }
        
        //Relational Properties
        public ICollection<MovieGenreDTO> MovieGenres { get; set; }
    }
}
