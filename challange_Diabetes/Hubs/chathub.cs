using challenge_Diabetes.Model;
using challenge_Diabetes.Services;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace challenge_Diabetes.Hubs
{
    public class chathub: Hub

    {
        private readonly IMessageRepository _messageRepository;

        public chathub(IMessageRepository messageRepository)
        {
            _messageRepository = messageRepository;
        }

        public async Task SendMessage(string sender, string recipient, string messageContent)
        {
            // Save message to the database
            var message = new Message { Sender = sender, Recipient = recipient, Content = messageContent };
            await _messageRepository.SaveMessageAsync(message);

            // Send message to recipient if online
            var recipientConnectionIds = await _messageRepository.GetConnectionIdsForUserAsync(recipient);
            foreach (var connectionId in recipientConnectionIds)
            {
                await Clients.Client(connectionId).SendAsync("ReceiveMessage", sender, messageContent);
            }
        }

        public override async Task OnConnectedAsync()
        {
            // Add connection id to user mapping in repository
            await _messageRepository.AddConnectionIdForUserAsync(Context.User.Identity.Name, Context.ConnectionId);
            await base.OnConnectedAsync();
        }

        public override async Task OnDisconnectedAsync(Exception exception)
        {
            // Remove connection id from user mapping in repository
            await _messageRepository.RemoveConnectionIdForUserAsync(Context.User.Identity.Name, Context.ConnectionId);
            await base.OnDisconnectedAsync(exception);
        }
    }

}

