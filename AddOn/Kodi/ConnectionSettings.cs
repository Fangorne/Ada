using System;

namespace  KODIRPC
{
    public class ConnectionSettings
    {
        public string Host;
        public int Port;
		public int TcpPort=9090;
        public string UserName;
        public string Password;
        public Uri JsonInterfaceAddress;
        public Uri BaseAddress;


        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionSettings"/> class.
        /// </summary>
        /// <param name="host">The host.</param>
        /// <param name="port">The port.</param>
        /// <param name="userName">Name of the user.</param>
        /// <param name="password">The password.</param>
        public ConnectionSettings(string host, int port, string userName, string password)
        {
            Host = host;
            Port = port;
            UserName = userName;
            Password = password;
            JsonInterfaceAddress = new Uri(String.Format("http://{0}:{1}/jsonrpc", host, port));
            BaseAddress = new Uri(string.Format("http://{0}:{1}", host, port));
        }
    }
}
