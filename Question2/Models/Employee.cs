using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Question2.Models;

public partial class Employee
{
    [Key]
    public int Id { get; set; }

    [StringLength(100)]
    public string? Name { get; set; }

    [StringLength(10)]
    public string? Gender { get; set; }

    public DateOnly? Dob { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? Phone { get; set; }

    [Column("IDNumber")]
    [StringLength(12)]
    [Unicode(false)]
    public string? Idnumber { get; set; }

    [InverseProperty("EmployeeNavigation")]
    public virtual ICollection<Service> Services { get; set; } = new List<Service>();
}
