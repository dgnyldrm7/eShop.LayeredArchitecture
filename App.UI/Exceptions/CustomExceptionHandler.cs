using Microsoft.AspNetCore.Diagnostics;

namespace App.UI.Exceptions
{
    public class CustomExceptionHandler : IExceptionHandler
    {
        public ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
