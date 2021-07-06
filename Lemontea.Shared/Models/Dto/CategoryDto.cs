using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Lemontea.Shared.Models.Dto
{
  public class CategoryDto
  {
    public Guid Id { get; set; }
    public string Description { get; set; }
    public int DisplayOrder { get; set;  }
    public bool IsChecked { get; set; }

    [JsonIgnore]
    public List<AziendaDto> Aziende;
  }
}
