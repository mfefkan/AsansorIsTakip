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
        public int PersonelID { get; set; }

    }
}
