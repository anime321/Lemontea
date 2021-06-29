using Lemontea.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lemontea.Services
{
  public interface ICategoryService
  {
    Task<OperationResult> GetAsync();
  }
}
