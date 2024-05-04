using challenge_Diabetes.DTO;
using challenge_Diabetes.Model;

namespace challenge_Diabetes.Services
{
    public interface IAuthService
    {
        Task<AuthModel> RegisterAsync(RegisterModelDTO model);
        Task<AuthModel> Login(TokenRequestModelDTO model);
        Task<string> AddRoleAsync(AddRoleModelDTO model);
    }
}
