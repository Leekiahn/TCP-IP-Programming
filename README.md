# 🖧 TCP/IP Network Programming (C#)

이 프로젝트는 **C#을 이용한 기본적인 TCP/IP 네트워크 통신 예제**입니다.  
`TcpListener`와 `TcpClient` 클래스를 활용해 **서버와 클라이언트 간의 메시지 송수신**을 구현했습니다.

---

## 📂 프로젝트 구조

NetworkProgram/
├── Program.cs # 서버와 클라이언트 실행 제어 (엔트리 포인트)  
├── TcpServerApp.cs # TCP 서버 기능 (TcpListener 기반)  
├── TcpClientApp.cs # TCP 클라이언트 기능 (TcpClient 기반)  

---

## ⚙️ 주요 기능

| 구성 요소 | 설명 |
|------------|------|
| **TcpServerApp** | 서버 역할 수행. 클라이언트 연결을 기다리고, 메시지를 수신 후 응답 전송 |
| **TcpClientApp** | 서버에 연결해 메시지를 전송하고, 서버로부터 응답을 수신 |
| **Program.cs** | 서버와 클라이언트를 동시에 실행 (테스트용) |

server 브랜치와 client 브랜치가 따로 있습니다.
