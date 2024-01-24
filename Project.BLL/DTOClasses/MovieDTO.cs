using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DTOClasses
{
    public class MovieDTO : BaseDTO
    {
        public string MovieName { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public string VideoPath { get; set; }

        //Relational Properties
        public virtual ICollection<MovieCastDTO> MovieCasts { get; set; }
        public virtual ICollection<MovieGenreDTO> MovieGenres { get; set; }
    }
}
