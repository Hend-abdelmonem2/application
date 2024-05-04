using challenge_Diabetes.Data;
using challenge_Diabetes.Model;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Plugins;
using System.Security.Claims;
using Message = challenge_Diabetes.Model.Message;

namespace challenge_Diabetes.Services
{
    public class MessageRepository:IMessageRepository
    {

        private readonly string _connectionString;
        private readonly IUserRepository _userRepository;
        private readonly ApplicationDbContext _dbContext;

        public MessageRepository(string connectionString, IUserRepository userRepository, ApplicationDbContext dbContext)
        {
            _connectionString = connectionString;
            _userRepository = userRepository;
            _dbContext = dbContext;

        }
        public async Task SaveMessageAsync(Message message)
        {
            var senderId = await _userRepository.GetUserIdByUsernameAsync(message.Sender);
            if (senderId == null)
            {
                throw new UnauthorizedAccessException("Sender is not authenticated.");
            }

            // Check if sender matches authenticated user
        /*    if (senderId != Context.User.Identity.Name);
            {
                throw new UnauthorizedAccessException("Sender does not have permission to send messages on behalf of another user.");
            }
        */
            var recipientId = await _userRepository.GetUserIdByUsernameAsync(message.Recipient);
            if (recipientId == null)
            {
                throw new ArgumentException("Recipient does not exist.");
            }



            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();

                var query = "INSERT INTO Messages (Sender, Recipient, Content, Timestamp, IsRead) VALUES (@Sender, @Recipient, @Content, @Timestamp, @IsRead)";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Sender", message.Sender);
                    command.Parameters.AddWithValue("@Recipient", message.Recipient);
                    command.Parameters.AddWithValue("@Content", message.Content);
                    command.Parameters.AddWithValue("@Timestamp", DateTime.UtcNow);
                    command.Parameters.AddWithValue("@IsRead", false);

                    await command.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task<IEnumerable<string>> GetConnectionIdsForUserAsync(string username)
        {
            var connectionIds = new List<string>();
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();

                var query = "SELECT ConnectionId FROM UserConnections WHERE Username = @Username";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            connectionIds.Add(reader.GetString(0));
                        }
                    }
                }
            }
            return connectionIds;
        }

        public async Task AddConnectionIdForUserAsync(string username, string connectionId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();

                var query = "INSERT INTO UserConnections (Username, ConnectionId) VALUES (@Username, @ConnectionId)";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@ConnectionId", connectionId);

                    await command.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task RemoveConnectionIdForUserAsync(string username, string connectionId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();

                var query = "DELETE FROM UserConnections WHERE Username = @Username AND ConnectionId = @ConnectionId";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@ConnectionId", connectionId);

                    await command.ExecuteNonQueryAsync();
                }
            }
        }
    }


}

