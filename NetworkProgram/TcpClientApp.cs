using System.Net.Sockets;

namespace NetworkProgram;

public class TcpClientApp
{
    public void ClientRun()
    {
        Console.Write("서버 IP 주소를 입력하세요:");
        string? ipAddress = Console.ReadLine();
        TcpClient client = new TcpClient(ipAddress, 5000);
        Console.WriteLine("서버에 연결되었습니다: " + client.Client.RemoteEndPoint);
        
        NetworkStream stream = client.GetStream();
        
        while (true)
        {
            Console.Write("서버로 보낼 메시지 입력: ");
            string message = Console.ReadLine() ?? "";
            byte[] messageBytes = System.Text.Encoding.UTF8.GetBytes(message);  // 메시지 인코딩
            stream.Write(messageBytes, 0, messageBytes.Length); // 메시지 전송

            byte[] buffer = new byte[1024];
            int bytesRead = stream.Read(buffer, 0, buffer.Length);
            string response = System.Text.Encoding.UTF8.GetString(buffer, 0, bytesRead);    // 서버로부터 받은 응답 디코딩
            Console.WriteLine("서버로부터 받은 응답: " + response);  // 서버로부터 받은 응답 출력
        }
    }
}