using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UoM2023_ConsoleApp.Models;

[Keyless]
[Table("UnitsOfMeasure")]
public partial class UnitsOfMeasure
{
    [StringLength(70)]
    [Unicode(false)]
    public string? Name { get; set; }

    [Column("QuantityType_0")]
    [StringLength(200)]
    [Unicode(false)]
    public string? QuantityType0 { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? DimensionalClass { get; set; }

    [Column("SameUnit_0__uom")]
    [StringLength(50)]
    [Unicode(false)]
    public string? SameUnit0Uom { get; set; }

    [Column("SameUnit_0__namingSystem")]
    [StringLength(20)]
    [Unicode(false)]
    public string? SameUnit0NamingSystem { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? CatalogName { get; set; }

    [Column("CatalogSymbol__isExplicit")]
    public bool? CatalogSymbolIsExplicit { get; set; }

    [Column("CatalogSymbol___text")]
    [StringLength(40)]
    [Unicode(false)]
    public string? CatalogSymbolText { get; set; }

    [Column("_id")]
    [StringLength(40)]
    [Unicode(false)]
    public string? Id { get; set; }

    [Column("_annotation")]
    [StringLength(40)]
    [Unicode(false)]
    public string? Annotation { get; set; }

    [Column("QuantityType_1")]
    [StringLength(200)]
    [Unicode(false)]
    public string? QuantityType1 { get; set; }

    [Column("BaseUnit_BasicAuthority")]
    [StringLength(20)]
    [Unicode(false)]
    public string? BaseUnitBasicAuthority { get; set; }

    [Column("QuantityType_2")]
    [StringLength(200)]
    [Unicode(false)]
    public string? QuantityType2 { get; set; }

    [Column("BaseUnit_Description")]
    [StringLength(300)]
    [Unicode(false)]
    public string? BaseUnitDescription { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Deprecated { get; set; }

    [Column("QuantityType_3")]
    [StringLength(200)]
    [Unicode(false)]
    public string? QuantityType3 { get; set; }

    [Column("QuantityType_4")]
    [StringLength(200)]
    [Unicode(false)]
    public string? QuantityType4 { get; set; }

    [Column("QuantityType_5")]
    [StringLength(200)]
    [Unicode(false)]
    public string? QuantityType5 { get; set; }

    [Column("QuantityType_6")]
    [StringLength(200)]
    [Unicode(false)]
    public string? QuantityType6 { get; set; }

    [Column("QuantityType_7")]
    [StringLength(200)]
    [Unicode(false)]
    public string? QuantityType7 { get; set; }

    [Column("SameUnit_1__uom")]
    [StringLength(40)]
    [Unicode(false)]
    public string? SameUnit1Uom { get; set; }

    [Column("SameUnit_1__namingSystem")]
    [StringLength(40)]
    [Unicode(false)]
    public string? SameUnit1NamingSystem { get; set; }

    [Column("SameUnit_2__uom")]
    [StringLength(40)]
    [Unicode(false)]
    public string? SameUnit2Uom { get; set; }

    [Column("SameUnit_2__namingSystem")]
    [StringLength(40)]
    [Unicode(false)]
    public string? SameUnit2NamingSystem { get; set; }

    [Column("QuantityType_8")]
    [StringLength(200)]
    [Unicode(false)]
    public string? QuantityType8 { get; set; }

    [Column("QuantityType_9")]
    [StringLength(200)]
    [Unicode(false)]
    public string? QuantityType9 { get; set; }

    [Column("QuantityType_10")]
    [StringLength(200)]
    [Unicode(false)]
    public string? QuantityType10 { get; set; }

    [Column("QuantityType_11")]
    [StringLength(200)]
    [Unicode(false)]
    public string? QuantityType11 { get; set; }

    [Column("QuantityType_12")]
    [StringLength(200)]
    [Unicode(false)]
    public string? QuantityType12 { get; set; }

    [Column("ConversionToBaseUnit_Factor")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ConversionToBaseUnitFactor { get; set; }

    [Column("ConversionToBaseUnit__baseUnit")]
    [StringLength(60)]
    [Unicode(false)]
    public string? ConversionToBaseUnitBaseUnit { get; set; }

    [Column("ConversionToBaseUnit_Fraction_Numerator")]
    [StringLength(60)]
    [Unicode(false)]
    public string? ConversionToBaseUnitFractionNumerator { get; set; }

    [Column("ConversionToBaseUnit_Fraction_Denominator")]
    [StringLength(60)]
    [Unicode(false)]
    public string? ConversionToBaseUnitFractionDenominator { get; set; }

    [Column("ConversionToBaseUnit_Formula_A")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ConversionToBaseUnitFormulaA { get; set; }

    [Column("ConversionToBaseUnit_Formula_B")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ConversionToBaseUnitFormulaB { get; set; }

    [Column("ConversionToBaseUnit_Formula_C")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ConversionToBaseUnitFormulaC { get; set; }

    [Column("ConversionToBaseUnit_Formula_D")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ConversionToBaseUnitFormulaD { get; set; }

    [Column("SameUnit_3__uom")]
    [StringLength(50)]
    [Unicode(false)]
    public string? SameUnit3Uom { get; set; }

    [Column("SameUnit_3__namingSystem")]
    [StringLength(50)]
    [Unicode(false)]
    public string? SameUnit3NamingSystem { get; set; }
}
