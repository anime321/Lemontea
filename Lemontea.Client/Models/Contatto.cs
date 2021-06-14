﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lemontea.Client.Models
{
  public class Contatto
  {
    public int Id { get; set; }

    [Required]
    [StringLength(50)]
    public string Nome { get; set; }

    [Required]
    [StringLength(50)]
    public string Cognome { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [StringLength(50)]
    public string Telefono { get; set; }

    [StringLength(50)]
    public string Cellulare { get; set; }
  }
}
