using System.Threading.Tasks;

namespace Ada.AddOn.Kodi
{
    public interface ISocketFactory
    {
        ISocket GetSocket();
        Task<string[]> ResolveHostname(string hostname);
    }
}