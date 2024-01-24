using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class MovieCast : BaseEntity
    {
        public int MovieID { get; set; }
        public int CastID { get; set; }
        public string? NameInMovie { get; set; }

        //Relational Properties
        public virtual Movie Movie { get; set; }
        public virtual Cast Cast { get; set; }
    }
}
