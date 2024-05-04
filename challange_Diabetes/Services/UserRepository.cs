using challenge_Diabetes.Data;
using Microsoft.EntityFrameworkCore;

namespace challenge_Diabetes.Services
{
    public class UserRepository: IUserRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public UserRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<string> GetUserIdByUsernameAsync(string username)
        {
            var user = await _dbContext.Users.SingleOrDefaultAsync(u => u.UserName == username);
            return user?.Id; // Assuming Id is the user identifier in your database
        }
    }
}
