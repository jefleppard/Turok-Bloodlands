using System;
using WebSocketSharp;

namespace Socket
{
    public class Sock
    {
        public static void Main(string[] args)
        {
            using (var ws = new WebSocket("ws://dragonsnest.far/Laputa"))
            {
                ws.OnMessage += (sender, e) =>
                    Console.WriteLine("Laputa says: " + e.Data);

                ws.Connect();
                ws.Send("BALUS");
                // Console.ReadKey(true);
            }
        }
    }
}
