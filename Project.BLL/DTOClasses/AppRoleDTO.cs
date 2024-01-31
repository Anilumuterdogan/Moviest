using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DTOClasses
{
    public class AppRoleDTO : BaseDTO
    {
        public string Name { get; set; }
        //Relational Properties
        public AppUserRoleDTO UserRoleDTO { get; set; }
    }
}
