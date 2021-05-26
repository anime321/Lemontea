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
    [StringLength(50)]
    public string RagioneSociale { get; set; }

    [Required]
    [StringLength(50)]
    public string Indirizzo { get; set; }

    [Required]
    [StringLength(50)]
    public string NCivico { get; set; }

    [Required]
    [DataType(DataType.PostalCode)]
    public int CAP { get; set; }

    [Required]
    [StringLength(50)]
    public string Nazione { get; set; }

    [StringLength(50)]
    public string Provincia { get; set; }

    [Required]
    [StringLength(50)]
    public string Citta { get; set; }

    [DataType(DataType.PhoneNumber)]
    public string Telefono { get; set; }

    [DataType(DataType.PhoneNumber)]
    public string Fax { get; set; }

    [Required]
    [EmailAddress]
    [StringLength(50)]
    public string Email { get; set; }

    [Required]
    [Url]
    [StringLength(50)]
    public string SitoWeb { get; set; }

    [Required]
    [StringLength(11)]
    public string PartitaIVA { get; set; }

    [StringLength(16)]
    public string CodiceFiscale { get; set; }
  }
}
