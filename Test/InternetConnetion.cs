using System.Net.NetworkInformation;

namespace Test.Validation
{
    public static class InternetConnetion
    {
        public static bool Check()
        {
            try
            {
                var ping = new Ping();
                var host = "8.8.8.8";
                int timeout = 5000;
                var reply = ping.Send(host, timeout);
                return reply.Status == IPStatus.Success;
            }
            catch (PingException)
            {
                return false;
            }
        }
    }
}

//var ping = new Ping();
//var host = "google.com";
//var buffer = new byte[32];
//int timeout = 10000;
//var pingOptions = new PingOptions();
//var reply = ping.Send(host, timeout, buffer, pingOptions);
//return (reply.Status == IPStatus.Success);