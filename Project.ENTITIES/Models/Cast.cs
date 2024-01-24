using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Cast : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }      
        public string? Description { get; set; }
        public string? ImgagePath { get; set; }
        public string? VideoPath { get; set; }        

        //Relational Properties
        public virtual ICollection<MovieCast> MovieCasts { get; set; }


    }
}
