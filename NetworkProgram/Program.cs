using System.Net;

namespace NetworkProgram;

class Program
{
    static void Main(string[] args)
    {
        Task serverTask = Task.Run(() =>
        {
            TcpServerApp server = new TcpServerApp();
            server.ServerRun(IPAddress.Loopback.ToString());
        });
        
        Task.Delay(500).Wait(); // 서버가 시작될 시간을 잠시 대기
        
        TcpClientApp client = new TcpClientApp();
        client.ClientRun();
        
        serverTask.Wait();
    }
}