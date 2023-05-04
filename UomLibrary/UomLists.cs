using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UomLibrary.Models;
using UomLibrary.Data;

namespace UomLibrary
{
    public class UomLists
    {
        
        public static List<UnitsOfMeasure> getUnitsOfMeasure(Uom2023Context context)
        {
            //using Uom2023Context context = new Uom2023Context();
            return context.UnitsOfMeasures.ToList();
        }

        public static List<SameUnit> GetSameUnits(Uom2023Context context)
        {
            //using Uom2023Context context = new Uom2023Context();
            return context.SameUnits.ToList();
        }

        public static List<QuantityType> GetQuantityTypes(Uom2023Context context)
        {
            //using Uom2023Context context = new Uom2023Context();
            return context.QuantityTypes.ToList();
        }

        public static List<ConversionToBaseUnit> GetConversions(Uom2023Context context)
        {
            //using Uom2023Context context = new Uom2023Context();
            return context.ConversionToBaseUnits.ToList();
        }
    }
}
