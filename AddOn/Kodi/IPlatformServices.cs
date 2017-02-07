using KODIRPC;

namespace Ada.AddOn.Kodi
{

    public interface IPlatformServices
    {
        ISocketFactory SocketFactory { get; }
    }
}