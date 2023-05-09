using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TallerPOO.Models.dbModels;

[Table("productos", Schema = "farmacia")]
public partial class Producto
{
    [Key]
    [Column("Id_prod")]
    public int IdProd { get; set; }

    [Column("nom_prod")]
    [StringLength(50)]
    public string NomProd { get; set; } = null!;

    [Column("prec_prod")]
    public int PrecProd { get; set; }

    [Column("cant_prod")]
    public int CantProd { get; set; }
}
