using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIES.Models
{
    public class Contract:BaseEntity
    {
        public string ElevatorCount { get; set; }
        public string ElevatorsDescription { get; set; }
        public decimal MaintenanceFee { get; set; }
        public string FlatAddress { get; set; }
        public int PersonelID { get; set; }

        //Relational Properties

        public virtual Customer Customer { get; set; }
    }
}
