using UnityEngine;
using UnityEngine.Networking;


public class CustomNetworkDiscovery : NetworkDiscovery
{

    void Start()
    {
        Debug.Log("Start Discovery");
        Initialize();
        if (!NetworkServer.active)
            StartAsClient();
    }

    public override void OnReceivedBroadcast(string fromAddress, string data)
    {
        Debug.Log("Received Broadcast Message with Data " + fromAddress);
        NetworkManager.singleton.networkAddress = fromAddress;
        if (!NetworkClient.active)
            NetworkManager.singleton.StartClient();
    }
}