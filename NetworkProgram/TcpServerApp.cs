using System.Net;
using System.Net.Sockets;

namespace NetworkProgram;

public class TcpServerApp
{
    public void ServerRun(string ipAddress)
    {
        TcpListener server = new TcpListener(IPAddress.Parse(ipAddress), 5000);
        server.Start();
        Console.WriteLine("서버가 시작되었습니다. 클라이언트 연결을 기다리는 중..." + server.LocalEndpoint);
        
        TcpClient client = server.AcceptTcpClient();
        Console.WriteLine("클라이언트가 연결되었습니다: " + client.Client.RemoteEndPoint);
        
        NetworkStream stream = client.GetStream();

        while (true)
        {
            byte[] buffer = new byte[1024];
            int bytesRead = stream.Read(buffer, 0, buffer.Length);
            if (bytesRead == 0)
            {
                break; // 클라이언트가 연결을 종료한 경우
            }

            string message = System.Text.Encoding.UTF8.GetString(buffer, 0, bytesRead); // 클라이언트로부터 받은 메시지 디코딩
            Console.WriteLine("클라이언트로부터 받은 메시지: " + message);

            // 클라이언트에게 응답 보내기
            Console.Write("클라이언트로 보낼 메시지 입력: ");
            string response = Console.ReadLine() ?? "";
            byte[] responseBytes = System.Text.Encoding.UTF8.GetBytes(response);    // 응답 인코딩
            stream.Write(responseBytes, 0, responseBytes.Length);   // 응답 전송
        }
    }
}