using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identity.Helpers
{
    using System.Net;
    using System.Net.Sockets;

    namespace Identity.Helpers
    {
        public class IpHelper
        {
            public static string GetIpAddress()
            {
                var host = Dns.GetHostEntry(Dns.GetHostName());
                foreach (var ip in host.AddressList)
                {
                    if (ip.AddressFamily == AddressFamily.InterNetwork)
                    {
                        return ip.ToString();
                    }
                }
                return string.Empty;
            }
        }
    }
}
