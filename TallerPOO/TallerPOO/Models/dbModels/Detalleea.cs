using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TallerPOO.Models.dbModels;

[Table("detalleea", Schema = "farmacia")]
public partial class Detalleea
{
    [Key]
    [Column("id_detalleEA")]
    public int IdDetalleEa { get; set; }

    [Column("id_empl")]
    public int IdEmpl { get; set; }

    [Column("nom_alm")]
    [StringLength(50)]
    public string NomAlm { get; set; } = null!;

    [Column("fecha_detalleEA", TypeName = "date")]
    public DateTime FechaDetalleEa { get; set; }
}
