using UomLibrary.Data;
using UomLibrary.Models;
using TestUomLibrary.Data;
using static UomLibrary.Data.Uom2023Context;

namespace TestUomLibrary;

public class Program : UomLibrary.Data.Uom2023Context
{
    public static void Main()
    {
        using UomDbContext context = new UomDbContext();
        var Units = UomLibrary.UomLists.getUnitsOfMeasure(context);
        foreach(UnitsOfMeasure unit in Units)
        {
            Console.WriteLine($"{unit.UomId}: {unit.Name}");
        }
    }
}