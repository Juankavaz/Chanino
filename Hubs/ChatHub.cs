using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace Chanino
{
    public class ChatHub : Hub
    {
        public async Task EnviarMensaje(string IdentityUser, string mensaje)
        {
            await Clients.All.SendAsync("RecibirMensaje", IdentityUser, mensaje);
        }
    }
}
