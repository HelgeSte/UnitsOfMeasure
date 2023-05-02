using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Uom2023.Models;

[Table("UnitsOfMeasure")]
public partial class UnitsOfMeasure
{
    [Key]
    public int UomId { get; set; }

    [StringLength(70)]
    [Unicode(false)]
    public string? Name { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? DimensionalClass { get; set; }

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

    [Column("BaseUnit_BasicAuthority")]
    [StringLength(20)]
    [Unicode(false)]
    public string? BaseUnitBasicAuthority { get; set; }

    [Column("BaseUnit_Description")]
    [StringLength(300)]
    [Unicode(false)]
    public string? BaseUnitDescription { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Deprecated { get; set; }

    [InverseProperty("Uom")]
    public virtual ICollection<ConversionToBaseUnit> ConversionToBaseUnits { get; set; } = new List<ConversionToBaseUnit>();

    [InverseProperty("Uom")]
    public virtual ICollection<QuantityType> QuantityTypes { get; set; } = new List<QuantityType>();

    [InverseProperty("Uom")]
    public virtual ICollection<SameUnit> SameUnits { get; set; } = new List<SameUnit>();
}
