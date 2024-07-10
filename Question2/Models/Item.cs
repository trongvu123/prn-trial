using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Question2.Models;

[Table("items")]
public partial class Item
{
    [Key]
    [Column("itemId")]
    public int ItemId { get; set; }

    [Column("name")]
    [StringLength(255)]
    public string? Name { get; set; }

    [Column("price")]
    public double? Price { get; set; }

    [InverseProperty("Item")]
    public virtual ICollection<Category> Categories { get; set; } = new List<Category>();

    [InverseProperty("Item")]
    public virtual ICollection<ItemVarian> ItemVarians { get; set; } = new List<ItemVarian>();
}
