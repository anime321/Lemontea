using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemontea.Shared.Models.Dto
{
  public class CountryDto
  {
    public string Language { get; set; }

    public string Alpha2Code { get; set; }

    public string Alpha3Code { get; set; }

    public string Numeric3Code { get; set; }

    public string CountryName { get; set; }

    public string CountryType { get; set; }

    public string PhoneCode { get; set; }

    public List<StateDto> States { get; set; }
  }
}
