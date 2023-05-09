using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TallerPOO.Models.dbModels;

[Table("almacen", Schema = "farmacia")]
public partial class Almacen
{
    [Key]
    [Column("Id_alm")]
    public int IdAlm { get; set; }

    [Column("nom_alm")]
    [StringLength(60)]
    public string NomAlm { get; set; } = null!;
}
