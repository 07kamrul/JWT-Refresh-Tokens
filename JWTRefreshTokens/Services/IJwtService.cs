using JWTRefreshTokens.Models;
using System.Threading.Tasks;

namespace JWTRefreshTokens.Services
{
    public interface IJwtService
    {
        Task<string> GetTokenAsync(AuthRequest authRequest);
    }
}
