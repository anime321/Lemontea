using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lemontea.Shared.Models.Dto
{
  public class AziendaDto
  {
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
  }
}

