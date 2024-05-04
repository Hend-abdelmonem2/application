using challenge_Diabetes.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
namespace challenge_Diabetes.Services
{
    public interface IMessageRepository
    {
        Task SaveMessageAsync(Message message);
        Task<IEnumerable<string>> GetConnectionIdsForUserAsync(string username);
        Task AddConnectionIdForUserAsync(string username, string connectionId);
        Task RemoveConnectionIdForUserAsync(string username, string connectionId);
    }
}
