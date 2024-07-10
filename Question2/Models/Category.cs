using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Question2.Models;

[Table("categories")]
public partial class Category
{
    [Key]
    [Column("catID")]
    public int CatId { get; set; }

    [Column("name")]
    [StringLength(255)]
    public string? Name { get; set; }

    [Column("itemId")]
    public int? ItemId { get; set; }

    [ForeignKey("ItemId")]
    [InverseProperty("Categories")]
    public virtual Item? Item { get; set; }
}
