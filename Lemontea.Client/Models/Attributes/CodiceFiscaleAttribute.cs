using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


//
// custom validation attribute example (useless for regex checks as we can use RegularExpression attribute directly)
//

namespace Lemontea.Client.Models.Attributes
{
  public class CodiceFiscaleAttribute : ValidationAttribute
  {
    private readonly Regex cfRegex = new Regex(
      @"/^(?:[A-Z][AEIOU][AEIOUX]|[B-DF-HJ-NP-TV-Z]{2}[A-Z]){2}(?:[\dLMNP-V]{2}(?:[A-EHLMPR-T](?:[04LQ][1-9MNP-V]|[15MR][\dLMNP-V]|[26NS][0-8LMNP-U])|[DHPS][37PT][0L]|[ACELMRT][37PT][01LM]|[AC-EHLMPR-T][26NS][9V])|(?:[02468LNQSU][048LQU]|[13579MPRTV][26NS])B[26NS][9V])(?:[A-MZ][1-9MNP-V][\dLMNP-V]{2}|[A-M][0L](?:[1-9MNP-V][\dLMNP-V]|[0L][1-9MNP-V]))[A-Z]$/i"
    );

    public CodiceFiscaleAttribute() { }

    public string GetErrorMessage() =>
      "Il formato del codice fiscale non è valido.";

    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
      var azienda = (Azienda)validationContext.ObjectInstance;

      return ValidationResult.Success;
    }
  }
}
