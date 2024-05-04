namespace challenge_Diabetes.Services
{
    public interface IUserRepository
    {
        Task<string> GetUserIdByUsernameAsync(string username);
    }
}
