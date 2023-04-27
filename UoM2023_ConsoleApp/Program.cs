namespace UoM2023_ConsoleApp;
using UoM2023_ConsoleApp.Data;
using UoM2023_ConsoleApp.Models;

internal class Program
{
    public static void Main()
    {
        using Uom2023Context context = new Uom2023Context();
        int counter = 0;
        foreach(UnitsOfMeasure uom in context.UnitsOfMeasures)
        {
            // Want to split the QuantityType data and SameUnit data into their own tables 
            Console.WriteLine($"Id: {uom.Id,-6} Name: {uom.Name,-25} QT: {uom.QuantityType0,-30} SU: {uom.SameUnit0Uom}");
            if(counter > 10)
            {
                break;
            } 
            counter++;
        }
    }
}