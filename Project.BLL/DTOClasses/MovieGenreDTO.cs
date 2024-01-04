using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DTOClasses
{
    public class MovieGenreDTO : BaseDTO
    {
        public int MovieID { get; set; }
        public int GenreID { get; set; }

        //Relational Properties
        public MovieDTO Movie { get; set; }
        public GenreDTO Genre { get; set; }
    }
}
