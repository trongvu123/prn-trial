using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Question2.Models;

public partial class Service
{
    [Key]
    public int Id { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? RoomTitle { get; set; }

    public byte? Month { get; set; }

    public int? Year { get; set; }

    [StringLength(50)]
    public string? FeeType { get; set; }

    [Column(TypeName = "money")]
    public decimal? Amount { get; set; }

    public DateOnly? PaymentDate { get; set; }

    public int? Employee { get; set; }

    [ForeignKey("Employee")]
    [InverseProperty("Services")]
    public virtual Employee? EmployeeNavigation { get; set; }

    [ForeignKey("RoomTitle")]
    [InverseProperty("Services")]
    public virtual Room? RoomTitleNavigation { get; set; }
}
