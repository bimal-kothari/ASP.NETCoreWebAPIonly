using ASP.NETCoreWebAPI_only.Application.Common.Models;
using Microsoft.AspNetCore.Identity;

namespace ASP.NETCoreWebAPI_only.Infrastructure.Identity;

public static class IdentityResultExtensions
{
    public static Result ToApplicationResult(this IdentityResult result)
    {
        return result.Succeeded
            ? Result.Success()
            : Result.Failure(result.Errors.Select(e => e.Description));
    }
}
