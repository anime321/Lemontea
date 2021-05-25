using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lemontea.Common
{
  public class OperationResult
  {
    public bool Success { get; }
    public object Content { get; }
    public FailureReason FailureReason { get; }

    internal OperationResult(bool success, FailureReason failureReason, object content = null)
    {
      Success = success;
      FailureReason = failureReason;
      Content = content;
    }

    internal static OperationResult Ok(object content = null)
      => new OperationResult(true, FailureReason.None, content);

    internal static OperationResult Fail(FailureReason failureReason, object content = null)
      => new OperationResult(false, failureReason, content);
  }
}
