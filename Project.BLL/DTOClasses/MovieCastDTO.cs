using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DTOClasses
{
    public class MovieCastDTO : BaseDTO
    {
        public int MovieID { get; set; }
        public int CastID { get; set; }

        //Relational Properties
        public virtual MovieDTO Movie { get; set; }
        public virtual CastDTO Cast { get; set; }
    }
}
