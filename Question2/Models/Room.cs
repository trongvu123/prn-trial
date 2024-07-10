using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Question2.Models;

public partial class Room
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string Title { get; set; } = null!;

    public byte? Square { get; set; }

    public byte? Floor { get; set; }

    [Column(TypeName = "ntext")]
    public string? Description { get; set; }

    [Column(TypeName = "ntext")]
    public string? Comment { get; set; }

    [InverseProperty("RoomTitleNavigation")]
    public virtual ICollection<Service> Services { get; set; } = new List<Service>();
}
