using AutoMapper;
using Project.BLL.DTOClasses;
using Project.BLL.ManagerServices.Abstracts;
using Project.DAL.Repositories.Abstracts;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.ManagerServices.Concretes
{
    public class CastManager : BaseManager<CastDTO, Cast>, ICastManager
    {
        ICastRepository _csRep;

        public CastManager(ICastRepository csRep, IMapper mapper) : base(csRep, mapper)
        {
            _csRep = csRep;
        }
    }
}
