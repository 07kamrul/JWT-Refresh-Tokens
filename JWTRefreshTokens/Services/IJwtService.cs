using JWTRefreshTokens.Models;
using System.Threading.Tasks;

namespace JWTRefreshTokens.Services
{
    public interface IJwtService
    {
        Task<AuthResponse> GetTokenAsync(AuthRequest authRequest, string ipAddress);
        Task<AuthResponse> GetRefreshTokenAsync(string ipAddress, int userid, string userName);
        Task<bool> IsTokenValid(string accessToken, string ipAddress);
    }
}
