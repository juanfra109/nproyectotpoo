using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TallerPOO.Models.dbModels;

[Table("empleado", Schema = "farmacia")]
public partial class Empleado
{
    [Key]
    [Column("Id_empl")]
    public int IdEmpl { get; set; }

    [Column("nom_empl")]
    [StringLength(60)]
    public string NomEmpl { get; set; } = null!;

    [Column("tel_emp")]
    [StringLength(10)]
    public string TelEmp { get; set; } = null!;

    [Column("RFC_empl")]
    [StringLength(50)]
    public string RfcEmpl { get; set; } = null!;

    [Column("dir_empl")]
    [StringLength(250)]
    public string DirEmpl { get; set; } = null!;

    [Column("turn_empl")]
    [StringLength(50)]
    public string TurnEmpl { get; set; } = null!;
}
