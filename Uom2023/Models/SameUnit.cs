using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Uom2023.Models;

[Table("SameUnit")]
public partial class SameUnit
{
    [Key]
    public int SameUnitId { get; set; }

    [Column("SameUnit_uom")]
    [StringLength(50)]
    [Unicode(false)]
    public string? SameUnitUom { get; set; }

    [Column("SameUnit_namingSystem")]
    [StringLength(50)]
    [Unicode(false)]
    public string? SameUnitNamingSystem { get; set; }

    public int? UomId { get; set; }

    [ForeignKey("UomId")]
    [InverseProperty("SameUnits")]
    public virtual UnitsOfMeasure? Uom { get; set; }
}
