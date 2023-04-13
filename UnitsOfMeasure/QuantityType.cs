using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsOfMeasure
{
    internal class QuantityType
    {
        /* ToDo: Find out what the QuantityTypes are used for, and if I can delete it from this project
         * Think the quantity types was used, because some Units had multiple quantity types. If so, it
         * might be much work to create an insert script */

        public int Id { get; }
        public string Name { get; set; }

        public QuantityType(string name)
        {
            Name = name;
        }
    }
}
