using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using UnityEngine;

public class Client : MonoBehaviour
{
    public string Host = "51.178.84.118";
    public int Port = 64000;



    private TcpClient socket = null;
    private NetworkStream ns = null;
    private StreamWriter sWriter = null;
    string msg;
    // Start is called before the first frame update
    void Start()
    {
        socket = new TcpClient();
        if (SetupSocket())
        {
            Debug.Log("socket is set up");
            SendMessage();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!socket.Connected)
        {
            SetupSocket();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SendMessage();
        }
    }

    bool SetupSocket() // set up tcp connection
    {
        try
        {
            socket.Connect(Host, Port);
            ns = socket.GetStream();
            sWriter = new StreamWriter(ns);
            byte[] sendBytes = System.Text.Encoding.UTF8.GetBytes("yah!! it works");
            socket.GetStream().Write(sendBytes, 0, sendBytes.Length);
            Debug.Log("socket is sent");
            return true;
        }
        catch (Exception e)
        {
            Debug.Log("Socket error: " + e);
            return false;
        }
    }

    public void SendChoice(string choice)
    {
        if (socket == null)
        {
            return;
        }
        try
        {
            NetworkStream stream = socket.GetStream();
            if (stream.CanWrite)
            {
                byte[] clientMessageAsByteArray = System.Text.Encoding.UTF8.GetBytes(choice);
                stream.Write(clientMessageAsByteArray, 0, clientMessageAsByteArray.Length);
                Debug.Log("Client sent his message - should be received by server");
            }
        }
        catch (SocketException socketException)
        {
            Debug.Log("Socket exception: " + socketException);
        }

    }

    void SendMessage() // send message to server from the client
    {
        if (socket == null)
        {
            return;
        }
        try
        {
            NetworkStream stream = socket.GetStream();
            if (stream.CanWrite)
            {
                string clientMessage = "This is a message from one of your clients.";
                byte[] clientMessageAsByteArray = System.Text.Encoding.UTF8.GetBytes(clientMessage);
                stream.Write(clientMessageAsByteArray, 0, clientMessageAsByteArray.Length);
                Debug.Log("Client sent his message - should be received by server");
            }
        }
        catch (SocketException socketException)
        {
            Debug.Log("Socket exception: " + socketException);
        }

    }

    private void OnApplicationQuit()
    {
        if (socket != null && socket.Connected)
            socket.Close();
    }
}
