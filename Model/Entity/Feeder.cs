using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entity
{
    public class Feeder : BaseEntity
    {
        public string Name { get; set; }
        public int Amount_of_food { get; set; }
    }
}
