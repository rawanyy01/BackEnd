using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevConnect.Models;

[Table("tb_publicacao")]
public partial class TbPublicacao
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("descricao")]
    [StringLength(100)]
    public string? Descricao { get; set; }

    [Column("imagem_url")]
    [StringLength(100)]
    public string ImagemUrl { get; set; } = null!;

    [Column("data_publicaco")]
    public DateOnly DataPublicaco { get; set; }

    [Column("id_usuario")]
    public int? IdUsuario { get; set; }

    [ForeignKey("IdUsuario")]
    [InverseProperty("TbPublicacao")]
    public virtual TbUsuario? IdUsuarioNavigation { get; set; }
}
