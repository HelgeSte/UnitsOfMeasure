using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UomLibrary.Models;

[Table("QuantityType")]
public partial class QuantityType
{
    [Key]
    public int QuantityTypeId { get; set; }

    [Column("QuantityType")]
    [StringLength(200)]
    [Unicode(false)]
    public string? QuantityType1 { get; set; }

    public int? UomId { get; set; }

    [ForeignKey("UomId")]
    [InverseProperty("QuantityTypes")]
    public virtual UnitsOfMeasure? Uom { get; set; }
}
