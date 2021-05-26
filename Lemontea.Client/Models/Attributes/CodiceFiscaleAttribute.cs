using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lemontea.Client.Models.Attributes
{
  public class CodiceFiscaleAttribute : ValidationAttribute
  {
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
