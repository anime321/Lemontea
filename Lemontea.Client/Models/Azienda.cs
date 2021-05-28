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
    [StringLength(50, MinimumLength = 3)]
    public string RagioneSociale { get; set; }

    [Required]
    [StringLength(50, MinimumLength = 3)]
    public string Indirizzo { get; set; }

    [Required]
    [StringLength(50)]
    public string NCivico { get; set; }

    [Required]
    [DataType(DataType.PostalCode)]
    public int CAP { get; set; }

    [Required]
    [StringLength(50, MinimumLength = 3)]
    public string Nazione { get; set; }

    [StringLength(50, MinimumLength = 2)]
    public string Provincia { get; set; }

    [Required]
    [StringLength(50, MinimumLength = 3)]
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
    //[RegularExpression(@"/^(?:[A-Z][AEIOU][AEIOUX]|[B-DF-HJ-NP-TV-Z]{2}[A-Z]){2}(?:[\dLMNP-V]{2}(?:[A-EHLMPR-T](?:[04LQ][1-9MNP-V]|[15MR][\dLMNP-V]|[26NS][0-8LMNP-U])|[DHPS][37PT][0L]|[ACELMRT][37PT][01LM]|[AC-EHLMPR-T][26NS][9V])|(?:[02468LNQSU][048LQU]|[13579MPRTV][26NS])B[26NS][9V])(?:[A-MZ][1-9MNP-V][\dLMNP-V]{2}|[A-M][0L](?:[1-9MNP-V][\dLMNP-V]|[0L][1-9MNP-V]))[A-Z]$/i")]
    public string CodiceFiscale { get; set; }
  }
}
