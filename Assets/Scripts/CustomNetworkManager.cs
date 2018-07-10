using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class CustomNetworkManager : NetworkManager
{
    private bool connected = false;
    public NetworkDiscovery discovery;

    private void OnGUI()
    {
        if (!connected)
        {
            Debug.Log("Starting the server...");
            NetworkManager.singleton.StartServer();
        }
        else
            GUILayout.Label("Connected");
    }

    void Start()
    {
        NetworkManager.singleton.networkPort = 7777;
        NetworkManager.singleton.networkAddress = "127.0.0.1";
    }

    public override void OnStartServer()
    {
        discovery.StopBroadcast();
        Debug.Log("Start Server Broadcast....");
        discovery.broadcastData = networkPort.ToString();
        discovery.StartAsServer();
        base.OnStartServer();
        connected = true;
    }

    public override void OnClientConnect(NetworkConnection conn)
    {
        Debug.Log("Client Connected to server");
        base.OnClientConnect(conn);
        connected = true;
    }
}