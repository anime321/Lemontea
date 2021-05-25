using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lemontea.Client.Models
{
  public class Azienda
  {
    public int Id { get; set; }

    [Required]
    public string RagioneSociale { get; set; }

    [Required]
    public string Indirizzo { get; set; }

    [Required]
    public string NCivico { get; set; }

    [Required]
    public int CAP { get; set; }

    [Required]
    public string Nazione { get; set; }

    public string Provincia { get; set; }

    [Required]
    public string Citta { get; set; }

    public string Telefono { get; set; }

    public string Fax { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    [Url]
    public string SitoWeb { get; set; }

    [Required]
    public string PartitaIVA { get; set; }

    public string CodiceFiscale { get; set; }
  }
}
