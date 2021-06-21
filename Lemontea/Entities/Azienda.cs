using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Lemontea.Entities
{
  [Table("Aziende")]
  public class Azienda
  {
    [Key]
    public int Id { get; set; }
    public string RagioneSociale { get; set; }
    public string Indirizzo { get; set; }
    public string NCivico { get; set; }
    public int CAP { get; set; }
    public string Nazione { get; set; }
    public string Provincia { get; set; }
    public string Citta { get; set; }
    public string Telefono { get; set; }
    public string Fax { get; set; }
    public string Email { get; set; }
    public string SitoWeb { get; set; }
    public string PartitaIVA { get; set; }
    public string CodiceFiscale { get; set; }

    public List<Contatto> Contatti { get; set; }
  }
}
