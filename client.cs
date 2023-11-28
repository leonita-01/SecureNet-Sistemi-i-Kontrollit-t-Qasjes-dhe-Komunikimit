using System;
using System.Net.Sockets;
using System.Net;
using System.Text;
amespace MultiClient
{
    class Program
    {
        private static readonly Socket ClientSocket = new Socket
            (AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        private const int PORT = 100;

        static void Main()
        {
            Console.Title = "Client";
            ConnectToServer();
            RequestLoop();
            Exit();
        }
          private static void ConnectToServer(){}
             private static void RequestLoop(){}
              private static void Exit(){}
    }

}