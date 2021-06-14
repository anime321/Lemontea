using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemontea.Shared.Models.Dto
{
  public class ContattoDto
  {
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Cognome { get; set; }
    public string Email { get; set; }
    public string Telefono { get; set; }
    public string Cellulare { get; set; }
  }
}
