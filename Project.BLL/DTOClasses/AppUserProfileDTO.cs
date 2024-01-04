using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DTOClasses
{
    public class AppUserProfileDTO : BaseDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Relational Properties
        public AppUserDTO AppUser { get; set; }
    }
}
