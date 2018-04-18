using UnityEngine;
using System.Collections;
using WebSocketSharp;



public class Socket : MonoBehaviour
{
    private WebSocket socket;
    void Start () {
        //using (var socket = new WebSocket("ws://138.68.60.143:80"))

        print("creating the socket connection");

        socket = new WebSocket("ws://138.68.60.143:80");

        //socket.Log.Level = LogLevel.Debug;

        socket.OnOpen += (sender, e) =>
            print("connected to the server");

        socket.OnError += (sender, e) =>
            print("error connecting " + e);

        socket.OnMessage += (sender, e) =>
            print("we got some data" + e.Data);

        socket.OnClose += (sender, e) =>
            print("connection closed" + e.Reason);

        socket.ConnectAsync();
    }
}