using ASP.NETCoreWebAPI_only.Infrastructure.Identity;

namespace ASP.NETCoreWebAPI_only.Web.Endpoints;

public class Users : EndpointGroupBase
{
    public override void Map(WebApplication app)
    {
        app.MapGroup(this)
            .MapIdentityApi<ApplicationUser>();
    }
}
