using System.ComponentModel;

namespace UnitsOfMeasure
{
    public class Units
    {
        public int UomId { get; set;  }
        public string BaseUnit_BasicAuthority { get; set; }
        public string BaseUnit_Description { get; set; }
        public string CatalogName { get; set; }
        public string CatalogSymbol_isExplicit { get; set; }
        public string CatalogSymbol_text { get; set; }
        // ToDo: Create a class for Conversions
        public string ConversionToBaseUnit_Factor { get; set; }
        public string ConversionToBaseUnit_Formula_A { get; set; }
        public string ConversionToBaseUnit_Formula_B { get; set; }
        public string ConversionToBaseUnit_Formula_C { get; set; }
        public string ConversionToBaseUnit_Formula_D { get; set; }
        public string ConversionToBaseUnit_Fraction_Denominator { get; set; }
        public string ConversionToBaseUnit_Fraction_Numerator { get; set; }
        public string ConversionToBaseUnit_baseUnit { get; set; }
        public string Deprecated { get; set; }
        public string DimensionalClass { get; set; }
        public string Name { get; set; }
        public string Annotation { get; set; }
        public string Id { get; set; }

        public Units(
            string catalogName, 
            string catalogSymbol_isExplicit, 
            string catalogSymbol_text, 
            string conversionToBaseUnit_baseUnit,
            string deprecated, 
            string dimensionalClass, 
            string name, 
            string annotation,
            string id)
        {
            CatalogName = catalogName;
            CatalogSymbol_isExplicit = catalogSymbol_isExplicit;
            CatalogSymbol_text = catalogSymbol_text;
            ConversionToBaseUnit_baseUnit = conversionToBaseUnit_baseUnit;
            Deprecated = deprecated;
            DimensionalClass = dimensionalClass;
            Name = name;
            Annotation = annotation;
            Id = id;
        }

        public Units(
            string catalogName, 
            string catalogSymbol_isExplicit, 
            string catalogSymbol_text, 
            string conversionToBaseUnit_Factor, 
            string conversionToBaseUnit_Formula_A, 
            string conversionToBaseUnit_Formula_B, 
            string conversionToBaseUnit_Formula_C, 
            string conversionToBaseUnit_Formula_D, 
            string conversionToBaseUnit_Fraction_Denominator, 
            string conversionToBaseUnit_Fraction_Numerator, 
            string conversionToBaseUnit_baseUnit, 
            string deprecated, string dimensionalClass, 
            string name, 
            string annotation, 
            string id) : 
            this(catalogName, catalogSymbol_isExplicit, catalogSymbol_text, conversionToBaseUnit_Factor, 
                conversionToBaseUnit_Formula_A, conversionToBaseUnit_Formula_B, conversionToBaseUnit_Formula_C, 
                conversionToBaseUnit_Formula_D, conversionToBaseUnit_Fraction_Denominator)
        {
            ConversionToBaseUnit_Fraction_Numerator = conversionToBaseUnit_Fraction_Numerator;
            ConversionToBaseUnit_baseUnit = conversionToBaseUnit_baseUnit;
            Deprecated = deprecated;
            DimensionalClass = dimensionalClass;
            Name = name;
            Annotation = annotation;
            Id = id;
        }
    }
}