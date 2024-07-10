using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Question2.Models;

[Table("itemVarians")]
public partial class ItemVarian
{
    [Key]
    [Column("variantId")]
    public int VariantId { get; set; }

    [Column("detail")]
    [StringLength(200)]
    public string? Detail { get; set; }

    [Column("color")]
    [StringLength(50)]
    public string? Color { get; set; }

    [Column("size")]
    [StringLength(30)]
    public string? Size { get; set; }

    [Column("itemId")]
    public int? ItemId { get; set; }

    [ForeignKey("ItemId")]
    [InverseProperty("ItemVarians")]
    public virtual Item? Item { get; set; }
}
