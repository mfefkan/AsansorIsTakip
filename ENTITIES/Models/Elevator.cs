using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIES.Models
{
    public class Elevator:BaseEntity
    {
        public string NumberOfFloors { get; set; }
        public string Capacity { get; set; }
        public string MotorPower { get; set; }
        public string SuspensionType { get; set; }
        public string DoorType { get; set; }
        public string ControlPanelType { get; set; }

        //Relational Properties

        public virtual Contract Contract { get; set; }



    }
}
