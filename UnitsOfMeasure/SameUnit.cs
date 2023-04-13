using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsOfMeasure
{
    internal class SameUnit
    {
        // ToDo: Create scripts for creating and inserting into tables. Creating the tables,
        // should be simple, but have do some work for joining same units with units
        public int Id { get; }
        public string SameUnit_namingSystem { get; set; }
        public string SameUnit_uom { get; set; }

        public SameUnit(string sameUnit_namingSystem, string sameUnit_uom)
        {
            SameUnit_namingSystem = sameUnit_namingSystem;
            SameUnit_uom = sameUnit_uom;
        }
    }
