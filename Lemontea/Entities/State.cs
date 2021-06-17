using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Lemontea.Entities
{
  [Table("States")]
  public class State
  {
    public string CountryAlpha2Code { get; set; }
    public string Alpha2Code { get; set; }

    [Column("State")]
    public string StateName { get; set; }
  }
}
