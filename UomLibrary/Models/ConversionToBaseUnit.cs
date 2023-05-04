using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UomLibrary.Models;

[Table("ConversionToBaseUnit")]
public partial class ConversionToBaseUnit
{
    [Key]
    public int ConversionId { get; set; }

    [Column("ConversionToBaseUnit_Factor")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ConversionToBaseUnitFactor { get; set; }

    [Column("ConversionToBaseUnit__baseUnit")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ConversionToBaseUnitBaseUnit { get; set; }

    [Column("ConversionToBaseUnit_Fraction_Numerator")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ConversionToBaseUnitFractionNumerator { get; set; }

    [Column("ConversionToBaseUnit_Fraction_Denominator")]
    [StringLength(100)]
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

    public int? UomId { get; set; }

    [ForeignKey("UomId")]
    [InverseProperty("ConversionToBaseUnits")]
    public virtual UnitsOfMeasure? Uom { get; set; }
}
