using System.Net;
namespace NetworkProgram;

class Program
{
    static void Main(string[] args)
    {
        TcpServerApp serverApp = new TcpServerApp();
        serverApp.ServerRun(IPAddress.Loopback.ToString());
    }
}