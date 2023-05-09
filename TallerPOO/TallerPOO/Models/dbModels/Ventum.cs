using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TallerPOO.Models.dbModels;

[Table("venta", Schema = "farmacia")]
public partial class Ventum
{
    [Key]
    [Column("Id_vent")]
    public int IdVent { get; set; }

    [Column("Fech_vent", TypeName = "date")]
    public DateTime FechVent { get; set; }

    [Column("total_vent", TypeName = "decimal(19, 4)")]
    public decimal TotalVent { get; set; }

    [Column("Id_empl")]
    public int IdEmpl { get; set; }
}
