namespace NetworkProgram;

class Program
{
    static void Main(string[] args)
    {
        TcpClientApp clientApp = new TcpClientApp();
        clientApp.ClientRun();
    }
}