using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIES.Models
{
    public class Customer:BaseEntity
    {
        public string CustomerName { get; set; }
        public string CustomerPhoneNumber { get; set; }
        public string CustomerMailAddress { get; set; }

        //Relational Properties

        public virtual List<Contract> Contracts { get; set; }
    }
}
