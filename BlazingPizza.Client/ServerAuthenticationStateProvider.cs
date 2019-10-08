using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BlazingPizza.Client
{
    public class ServerAuthenticationStateProvider : AuthenticationStateProvider
    {
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            // Currently, this returns fake data
            // In a moment, we'll get real data from the server
            var claim = new Claim(ClaimTypes.Name, "Faky");
            var identity = new ClaimsIdentity(new[] { claim }, "serverauth");
            return new AuthenticationState(new ClaimsPrincipal(identity));
        }
    }
}
