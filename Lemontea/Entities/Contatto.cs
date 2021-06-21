using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Lemontea.Entities
{
  [Table("Contatti")]
  public class Contatto
  {
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Cognome { get; set; }
    public string Email { get; set; }
    public string Telefono { get; set; }
    public string Cellulare { get; set; }
    public int AziendaId { get; set; }

    public Azienda Azienda { get; set; }
  }
}
