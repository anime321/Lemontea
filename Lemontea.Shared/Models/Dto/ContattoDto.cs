using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Lemontea.Shared.Models.Dto
{
  public class ContattoDto
  {
    public int Id { get; set; }

    [Required]
    [StringLength(50, MinimumLength = 2)]
    public string Nome { get; set; }

    [Required]
    [StringLength(50, MinimumLength = 2)]
    public string Cognome { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [StringLength(50)]
    public string Telefono { get; set; }

    [StringLength(50)]
    public string Cellulare { get; set; }

    [Required]
    public int AziendaId { get; set; }

    [JsonIgnore]
    public AziendaDto Azienda { get; set; }
  }
}
