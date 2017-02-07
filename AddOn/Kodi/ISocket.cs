using System;
using System.IO;
using System.Threading.Tasks;

namespace Ada.AddOn.Kodi
{

    public interface ISocket : IDisposable
    {
        Task ConnectAsync(string hostName, int port);
        Stream GetInputStream();
    }
}