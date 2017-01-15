using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace SignalRArchiveImport.Infra
{
    public class ProgressHub : Hub
    {
        public ProgressHub()
        {

        }

        public override Task OnConnected()
        {
            return base.OnConnected();
        }

        public override Task OnDisconnected(bool stopCalled)
        {
            return base.OnDisconnected(stopCalled);
        }

        public override Task OnReconnected()
        {
            return base.OnReconnected();
        }
    }
}
