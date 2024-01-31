using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DTOClasses
{
    public class AppUserRoleDTO : BaseDTO
    {
        public int RoleId { get; set; }
        public int UserId { get; set; }

        //Relational Properties
        public AppUserDTO AppUserDTO { get; set; }
        public AppRoleDTO AppRoleDTO { get; set; }
    }
}
