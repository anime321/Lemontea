using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Lemontea.Entities
{
  [Table("Categories")]
  public class Category
  {
    public Guid Id { get; set;  }
    public string Description { get; set; }
    public int DisplayOrder { get; set; }

    public List<Azienda> Aziende { get; set; }
  }
}
