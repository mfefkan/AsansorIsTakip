using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIES.Models
{
    public class Task : BaseEntity
    {
        public string Description { get; set; }

        //RelationalProperties
        public virtual List<TechnicalStaff> TechnicalStaff { get; set; }
        public virtual List<AdministrativeStaff> AdministrativeStaff { get; set;}

    }
}
