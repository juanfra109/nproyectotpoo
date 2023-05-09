using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TallerPOO.Models.dbModels;

[Table("detalle_ev", Schema = "farmacia")]
public partial class DetalleEv
{
    [Key]
    [Column("id_vent")]
    public int IdVent { get; set; }

    [Column("fech_vent", TypeName = "date")]
    public DateTime FechVent { get; set; }

    [Column("id_empl")]
    public int IdEmpl { get; set; }

    [Column("turn_empl")]
    [StringLength(50)]
    public string TurnEmpl { get; set; } = null!;
}
