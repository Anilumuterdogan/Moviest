﻿using Microsoft.EntityFrameworkCore.Update.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class MovieList : BaseEntity
    {
        public int AppUserID { get; set; }
        public int MovieID { get; set; }
        //Relational Properties
        public virtual AppUser AppUser { get; set; }
        public virtual Movie Movie { get; set; }


    }
}
