using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lemontea.Common
{
  [Route("api/[controller]")]
  [ApiController]
  public class ControllerBaseEx : ControllerBase
  {
    protected IActionResult CreateResponse(OperationResult operationResult)
    {
      if (operationResult.Success)
      {
        if (operationResult.Content != null)
        {
          return Ok(operationResult.Content);
        }
        else
        {
          return NoContent();
        }
      }

      var statusCode = operationResult.FailureReason switch
      {
        FailureReason.ItemNotFound => StatusCodes.Status404NotFound,
        FailureReason.ClientError => StatusCodes.Status400BadRequest,
        _ => StatusCodes.Status500InternalServerError
      };

      return StatusCode(statusCode);
    }
  }
}
