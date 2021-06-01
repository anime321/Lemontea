using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lemontea.Client.Models
{
  public class Country
  {
    public string Language { get; set; }

    public string Alpha2Code { get; set; }

    public string Alpha3Code { get; set; }

    public string Numeric3Code { get; set; }

    public string CountryName { get; set; }

    public string CountryType { get; set; }

    public string PhoneCode { get; set; }

    public List<State> States { get; set; }
  }
}
