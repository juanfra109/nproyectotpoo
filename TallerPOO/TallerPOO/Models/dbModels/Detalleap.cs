using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TallerPOO.Models.dbModels;

[Table("detalleap", Schema = "farmacia")]
public partial class Detalleap
{
    [Key]
    [Column("Id_detalleap")]
    public int IdDetalleap { get; set; }

    [Column("id_prod")]
    public int IdProd { get; set; }

    [Column("nom_prod")]
    public int NomProd { get; set; }

    [Column("Id_alm")]
    public int IdAlm { get; set; }

    [Column("nom_alm")]
    [StringLength(50)]
    public string NomAlm { get; set; } = null!;
}
